using UnityEngine;

public class MfCommanderReceives : MF_CommanderBattle, MF_IReceives
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public MF_IReceives.specialAffect_pas[] ReceiveSpecialAffect { get; set; }
    public void receiveDmg_pas(int dmg)
    {
        Debug.Log($"Received {dmg} damage.");
    }

    public void assistAttack_pas()
    {
        throw new System.NotImplementedException();
    }

    public void knockAway_pas(float seconds, float height)
    {
        throw new System.NotImplementedException();
    }
}
