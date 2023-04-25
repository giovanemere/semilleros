using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
public class MainMenu : MonoBehaviour
{
    public GameObject PanelRegistre ;
    public GameObject PanelLogin;

   
    public InputField UserNameInput;
    public InputField emailInput ;
    public InputField edadInput;
    public InputField password1 ;
    public InputField password2;
    public Text errorText ;
    public Text errorText2;
    public Text MessageLogin;
    public Button submitButton;

    readonly string getURL = "http://localhost/sqlconnect/register.php";

    public InputField UserNameLogin;
    public InputField passwordLogin;
    public Button submitLogin;
    public Dropdown gender,ocupation;
    int selectedOcupation, selectedGender;
    public void Awake()
    {
        List<string> opciones = new List<string>() { "No aplica", "Estudiante", "Profesional", "Independiente" };
        this.ocupation.AddOptions(opciones);
        List<string> opciones1 = new List<string>() { "Masculino", "Femenino" };
        this.gender.AddOptions(opciones1);
    }
    public void SelectedOcupacion()
    {
        selectedOcupation = this.ocupation.value + 1;
        Debug.Log(selectedOcupation+"O");
    }
    public void SelectedGenero()
    {
        selectedGender = this.gender.value + 1;
        Debug.Log(selectedGender+"G");

    }
    public void CallRegister()
    {
        StartCoroutine(Register());
    }
    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }
    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", UserNameLogin.text);
        form.AddField("password", passwordLogin.text);
        WWW www = new WWW("https://bakerytycoon.000webhostapp.com/unity/login.php", form);
        yield return www;
        if (www.text[0] == '0')
        {
            DBManager.username = UserNameLogin.text;
            MessageLogin.text = "Usuario existe";
            SceneManager.LoadScene("StartMenu");

        }
        else
        {
            MessageLogin.text = "User login failed";
        }
    }
    
        
    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", UserNameInput.text);
        form.AddField("email", emailInput.text);
        form.AddField("edad", edadInput.text);
        form.AddField("password", password1.text);
        form.AddField("ocupacion", selectedOcupation);
        form.AddField("sexo", selectedGender);


        WWW www = new WWW("https://bakerytycoon.000webhostapp.com/unity/register.php", form);
       yield return www;
       if (www.text == "0")
       {
           errorText2.text = "Usuario creado satisfactoriamente";
       }
       else
       {
           errorText2.text = "falla al registrar usuario";
       }


        /*
        
        UnityWebRequest www = UnityWebRequest.Post(getURL, form);

        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            errorText2.text = "Usuario creado satisfactoriamente";
        }
        else
        {
            errorText2.text = "falla al registrar usuario";
        }
        */
    }

    public void VerifyInputs()
    {
        if (UserNameInput.text == "" || emailInput.text == "" || edadInput.text == "" || password1.text == "" || password2.text == "")
        {
            errorText.text = "Por favor llenar todos los campos";
            return;
        }
     
        submitButton.interactable = (UserNameInput.text.Length >= 8 && password1.text.Length >= 8 && password2.text.Length >= 8);

        if (password1.text == password2.text)
        {
            errorText.text = "Procesando....";
        }
        else
        {
            errorText.text = "Las contraseñas no son iguales";
        }
    }
    public void VerifyInputsLogin()
    {
        if (UserNameLogin.text == "" || passwordLogin.text == "")
        {
            MessageLogin.text = "Por favor llenar todos los campos";
            return;

        }
        submitLogin.interactable = (UserNameLogin.text.Length >= 8 && passwordLogin.text.Length >= 8);


    }
    public void ShowRegistre()
    {
        PanelRegistre.SetActive(true);
        PanelLogin.SetActive(false);
    }
    public void ShowLogin()
    {
        PanelRegistre.SetActive(false);
        PanelLogin.SetActive(true);
    }

}
