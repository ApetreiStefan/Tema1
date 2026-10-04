using UnityEngine;
using Vuforia;

public class ProximityManager : MonoBehaviour
{

    [Header("Image Targets")]
    [SerializeField] private ObserverBehaviour targetA;
    [SerializeField] private ObserverBehaviour targetB;

    [Header("Model Animators")]
    [SerializeField] private Animator animatorA;
    [SerializeField] private Animator animatorB;

    [Header("Proximity Settings")]
    [SerializeField] private float triggerDistance = 0.25f;
    private float distance;
    private bool isClose = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(targetA != null && targetB != null)
        {
            distance = Vector3.Distance(targetA.transform.position, targetB.transform.position);
            if(animatorA != null && animatorB != null)
            {
                if(distance < triggerDistance)
                {
                    animatorA.SetTrigger("Attack");
                    animatorB.SetTrigger("Attack");
                }
                else
                {
                    animatorA.ResetTrigger("Attack");
                    animatorB.ResetTrigger("Attack");
                }

            }

        }
    }
}
