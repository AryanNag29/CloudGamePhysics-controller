using UnityEngine;

//it make sure rigidbody can't be removed
[RequireComponent(typeof(Rigidbody))]
public class PlayerControlles : MonoBehaviour
{
    #region variables

    //movement variables

    #endregion


    #region componentReference
    //rigidbody component
    [SerializeField] Rigidbody PlayerRb;
    public PlayerInput PlayerInput;

    #endregion


    #region Awake

    void Awake()
    {

    }
    #endregion


    #region Update
    // Update is called once per frame
    void Update()
    {

    }
    #endregion
}
