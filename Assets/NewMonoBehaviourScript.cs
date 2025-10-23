using UnityEngine;

/// <summary>
/// Modern, prefab-free locomotion:
/// - Left stick = move (relative to HMD forward on XZ)
/// - Right stick = snap turn
/// Requires CharacterController on the same GameObject, and a reference to CenterEyeAnchor.
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class SimpleRigLocomotion : MonoBehaviour
{
    [Header("Assign CenterEyeAnchor from PlayerRig/TrackingSpace")]
    public Transform cameraEye;

    [Header("Move")]
    public float moveSpeed = 1.8f;   // m/s
    public float gravity = -9.81f;   // m/s^2
    private float _yVel = 0f;

    [Header("Snap Turn")]
    public float snapAngleDeg = 45f;
    public float snapDeadzone = 0.7f;
    public float snapCooldown = 0.25f;
    private float _snapTimer = 0f;

    private CharacterController _cc;

    void Awake() => _cc = GetComponent<CharacterController>();

    void Update()
    {
        if (!_cc || cameraEye == null) return;

        // --- Move (Left stick) ---
        Vector2 move = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick); // LTouch
        Vector3 fwd = cameraEye.forward; fwd.y = 0; fwd.Normalize();
        Vector3 right = cameraEye.right; right.y = 0; right.Normalize();
        Vector3 planar = (fwd * move.y + right * move.x) * moveSpeed;

        // Gravity
        if (_cc.isGrounded && _yVel < 0) _yVel = -0.5f;
        _yVel += gravity * Time.deltaTime;

        Vector3 motion = new Vector3(planar.x, _yVel, planar.z);
        _cc.Move(motion * Time.deltaTime);

        // --- Snap turn (Right stick X) ---
        _snapTimer -= Time.deltaTime;
        Vector2 turn = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick); // RTouch
        if (_snapTimer <= 0f && Mathf.Abs(turn.x) >= snapDeadzone)
        {
            float sign = Mathf.Sign(turn.x);
            transform.Rotate(0f, sign * snapAngleDeg, 0f);
            _snapTimer = snapCooldown;
        }
    }
}