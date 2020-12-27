using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    public Transform masukanLoadingbar;

    [SerializeField]
    private float nilaiSekarang;
    [SerializeField]
    private float nilaiKecepatan;
    
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if(nilaiSekarang < 100){
            nilaiSekarang += nilaiKecepatan * Time.deltaTime;
            Debug.Log ((int) nilaiSekarang);
        } else {
            // Application.LoadLevel("Menu");
            SceneManager.LoadScene("Menu");
        }
        masukanLoadingbar.GetComponent<Image> ().fillAmount = nilaiSekarang / 100;
        
    }
}
