using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource audioSource;
    [SerializeField] float rcsThrust = 100;
    [SerializeField] float mainTrust = 100;


    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

    }

    private void ProcessInput()
    {
        Thrust();
        Rotate();

    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":

                print("Ok"); //TODO remove this line
                break;

			case "Finish":

				print ("Great job!");
				SceneManager.LoadScene (1);

                break;

            default:

                print("Game over");
				SceneManager.LoadScene (0);


                break;
        }

    }


    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Thrust");
            float thrustPerFrame = rcsThrust * Time.deltaTime;
            rigidBody.AddRelativeForce(Vector3.up * thrustPerFrame);
            if (!audioSource.isPlaying)//so the audio doesn't layer
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
    private void Rotate()
    {
        rigidBody.freezeRotation = true; //take manual controll of rotation
        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
        rigidBody.freezeRotation = false;
    }

}
