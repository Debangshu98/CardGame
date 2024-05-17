using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    [SerializeField] private InputField mobileNumberInput;
    [SerializeField] private InputField otpInput;
    [SerializeField] private Button sendOTPButton;
    [SerializeField] private Button loginButton;
    private string generatedOTP;

    private void Start()
    {
        sendOTPButton.onClick.AddListener(SendOTP);
        loginButton.onClick.AddListener(Login);
    }

    /// <summary>
    /// this function just sends an OTP to the screen and also checks the validity of the mobile number
    /// </summary>
    private void SendOTP()
    {
        if (mobileNumberInput.text.Length == 10)
        {
            generatedOTP = GenerateOTP();
            Debug.Log("OTP sent: " + generatedOTP);
            otpInput.text = generatedOTP;
        }
        else
        {
            Debug.LogError("Please enter valid number");
        }
    }

    /// <summary>
    /// here the login of the user takes place
    /// </summary>
    private void Login()
    {
        string enteredOTP = otpInput.text;
        if (enteredOTP == generatedOTP)
        {
            Debug.Log("Login successful!");
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Invalid OTP. Please try again.");
        }
    }

    /// <summary>
    /// this functon returns the generated random otp
    /// </summary>
    /// <returns></returns>
    private string GenerateOTP()
    {
        // Generate a random 4-digit OTP
        return Random.Range(1000, 10000).ToString();
    }
}
