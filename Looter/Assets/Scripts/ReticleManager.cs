using UnityEngine;
using Cursor = UnityEngine.Cursor;

public class ReticleManager : MonoBehaviour
{
    [SerializeField] private PlayerSC _playerSC;
    [SerializeField] private Transform _reticlePosition;

    private Vector3 _target;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;

        InitData();
    }

    private void InitData()
    {
        _playerSC.aimPos = new Vector2(0, 0);
    }

    private void Update()
    {
        CalculateAim();
    }

    private void FixedUpdate()
    {
        ExecuteAim();
    }
    private void ExecuteAim()
    {
        _reticlePosition.transform.position = new Vector2(_target.x, _target.y);
    }

    private void CalculateAim()
    {
        _target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        _playerSC.aimPos = new Vector2(_target.x, _target.y);
    }

}
