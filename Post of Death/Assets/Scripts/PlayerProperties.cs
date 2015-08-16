using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerProperties : MonoBehaviour 
{
    public Button StaminaBar1;
    public Button StaminaBar2;
    public Button StaminaBar3;
    public Button StaminaBar4;
    public Button StaminaBar5;

    public Button HealthBar1;
    public Button HealthBar2;
    public Button HealthBar3;
    public Button HealthBar4;
    public Button HealthBar5;

    

    private float m_Health;
    private float m_Stamina;

    void Start()
    {
		PlayerPrefs.SetFloat("Health", 5.0f);
		PlayerPrefs.SetFloat("Stamina", 5.0f);

		m_Health = PlayerPrefs.GetFloat("Health");
        m_Stamina = PlayerPrefs.GetFloat("Stamina");

        Debug.Log("Health: " + m_Health);
        Debug.Log("Stamina: " + m_Stamina);
    }


    //returns stamina in [0, 5] range
    public float GetStamina()
    {
        return m_Stamina;
    }

    public int GetStaminaFromBar()
    {
        if (StaminaBar1.enabled)
            return 1;

        if (StaminaBar2.enabled)
            return 2;

        if (StaminaBar3.enabled)
            return 3;

        if (StaminaBar4.enabled)
            return 4;

        if (StaminaBar5.enabled)
            return 5;

        return 0; 
    }

    public int GetHealthFromBar()
    {
        if (HealthBar1.enabled)
            return 1;

        if (HealthBar2.enabled)
            return 2;

        if (HealthBar3.enabled)
            return 3;

        if (HealthBar4.enabled)
            return 4;

        if (HealthBar5.enabled)
            return 5;

        return 0;
    }

    //Set Stamina in [0, 5] range
    public void SetStamina(float Stamina)
    {
        PlayerPrefs.SetFloat("Stamina", Stamina);

        m_Stamina = Stamina;
        
        int ShowStamina = (int)Mathf.Floor(Stamina);

        if (ShowStamina == 0)
        {
            StaminaBar1.enabled = false;
            StaminaBar2.enabled = false;
            StaminaBar3.enabled = false;
            StaminaBar4.enabled = false;
            StaminaBar5.enabled = false;
        }

        if (ShowStamina == 1)
        {
            StaminaBar1.enabled = true;
            StaminaBar2.enabled = false;
            StaminaBar3.enabled = false;
            StaminaBar4.enabled = false;
            StaminaBar5.enabled = false;
        }


        if (ShowStamina == 2)
        {
            StaminaBar1.enabled = true;
            StaminaBar2.enabled = true;
            StaminaBar3.enabled = false;
            StaminaBar4.enabled = false;
            StaminaBar5.enabled = false;
        }


        if (ShowStamina == 3)
        {
            StaminaBar1.enabled = true;
            StaminaBar2.enabled = true;
            StaminaBar3.enabled = true;
            StaminaBar4.enabled = false;
            StaminaBar5.enabled = false;
        }

        if (ShowStamina == 4)
        {
            StaminaBar1.enabled = true;
            StaminaBar2.enabled = true;
            StaminaBar3.enabled = true;
            StaminaBar4.enabled = true;
            StaminaBar5.enabled = false;
        }


        if (ShowStamina == 5)
        {
            StaminaBar1.enabled = true;
            StaminaBar2.enabled = true;
            StaminaBar3.enabled = true;
            StaminaBar4.enabled = true;
            StaminaBar5.enabled = true;
        }
    }


    //Set Health in [0, 5] range
    public void SetHealth(float Health)
    {
        //save value onto disk
        PlayerPrefs.SetFloat("Health", Health);


        int ShowHealth = (int)Mathf.Floor(Health);

        m_Health = Health;

        if (ShowHealth == 0)
        {
            HealthBar1.enabled = false;
            HealthBar2.enabled = false;
            HealthBar3.enabled = false;
            HealthBar4.enabled = false;
            HealthBar5.enabled = false;
        }

        if (ShowHealth == 1)
        {
            HealthBar1.enabled = true;
            HealthBar2.enabled = false;
            HealthBar3.enabled = false;
            HealthBar4.enabled = false;
            HealthBar5.enabled = false;
        }


        if (ShowHealth == 2)
        {
            HealthBar1.enabled = true;
            HealthBar2.enabled = true;
            HealthBar3.enabled = false;
            HealthBar4.enabled = false;
            HealthBar5.enabled = false;
        }


        if (ShowHealth == 3)
        {
            HealthBar1.enabled = true;
            HealthBar2.enabled = true;
            HealthBar3.enabled = true;
            HealthBar4.enabled = false;
            HealthBar5.enabled = false;
        }

        if (ShowHealth == 4)
        {
            HealthBar1.enabled = true;
            HealthBar2.enabled = true;
            HealthBar3.enabled = true;
            HealthBar4.enabled = true;
            HealthBar5.enabled = false;
        }


        if (ShowHealth == 5)
        {
            HealthBar1.enabled = true;
            HealthBar2.enabled = true;
            HealthBar3.enabled = true;
            HealthBar4.enabled = true;
            HealthBar5.enabled = true;
        }
    }

    //returns health in [0, 5] range
    public float GetHealth()
    {
        return m_Health;
    }
}
