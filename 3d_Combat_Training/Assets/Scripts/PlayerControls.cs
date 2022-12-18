using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControls : MonoBehaviour
{

    #region variables
    public float moveSpeed = 5f;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    private int count;
    private float xInput;
    private float zInput;
    public CharacterController playerController;
    private Vector3 moveDirection;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if(count >= 5)
        {
            winTextObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        moveDirection = new Vector3(xInput, 0, zInput);
        playerController.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
        
    }


}
