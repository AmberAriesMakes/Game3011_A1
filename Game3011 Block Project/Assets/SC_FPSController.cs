using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]

public class SC_FPSController : MonoBehaviour
{
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 11.5f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    public float Delay = 3.0f;
    public GameObject gameCanvas, goCanvas;
    public bool gcActive, ScanMode, ExtractMode;
    public int Scans, Extractions, Score;
    public Text buttonText, scansText, extractText, scoreText, finalScoreText;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    [HideInInspector]
    public bool canMove = true;

    void Start()
    {
        Scans = 6;
        Extractions = 3;
        characterController = GetComponent<CharacterController>();
        ScanMode = false;
        ExtractMode = true;
        gcActive = false;
    }

    void Update()
    {
        scansText.text = "Scans Remaining: " + Scans;
        extractText.text = "Extractions Remaining: " + Extractions;
        scoreText.text = "Score: " + Score;
        finalScoreText.text = "Final Score: " + Score;
        // We are grounded, so recalculate move direction based on axes
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        // Press Left Shift to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Player and Camera rotation
        if (!gcActive)
        {
            if (canMove)
            {
                rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
                rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
                playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
            }
        }
        if (gameCanvas != null)
        {
            if (gcActive)
            {
                gameCanvas.SetActive(true);
            }
            else
            {
                gameCanvas.SetActive(false);
            }

        }


        if (Input.GetKeyDown(KeyCode.Q))
        {
            gcActive = !gcActive;
        }

        if (ExtractMode)
        {
            buttonText.text = "Extract Mode";
        }

        if (ScanMode)
        {
            buttonText.text = "Scan Mode";
        }
        if (Extractions == 0)
        {
            Delay -= Time.deltaTime;
            if (Delay < 0)
            {
                if (gameCanvas != null)
                    gameCanvas.SetActive(false);
                if (goCanvas != null)
                    goCanvas.SetActive(true);
            }
        }
    }

    public void changeMode()
    {
        ScanMode = !ScanMode;
        ExtractMode = !ExtractMode;
    }

    public void closeScreen()
    {
        Destroy(goCanvas.gameObject);
        Destroy(gameCanvas.gameObject);
        gcActive = false;

    }
}