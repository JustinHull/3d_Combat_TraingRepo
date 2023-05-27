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
        count = 0;
        playerController = GetComponent<CharacterController>();
        FindObjectOfType<GameManager>().SetCountText(count);

        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
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
        if (other.gameObject.CompareTag("PickUp"))
        {
            count += 1;
            FindObjectOfType<GameManager>().SetCountText(count);
            other.gameObject.SetActive(false);

            SetCountText();
        }

        else if (other.gameObject.CompareTag("Enemy")) 
        {
            gameObject.SetActive(false); 
            FindObjectOfType<GameManager>().EndGame();


        }


    }
}