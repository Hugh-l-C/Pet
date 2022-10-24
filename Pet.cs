
public class Animal
{
    public bool Alive = true;
    public int health=1000;
    System.Timers.Timer healthTimer
        = new System.Timers.Timer();
    
    public Animal()
    {
        healthTimer.Interval = 100;
        healthTimer.Elapsed += UpdateHealth;
        healthTimer.AutoReset = true;
        healthTimer.Enabled = true;
    }
    private void UpdateHealth(
        Object source,
        System.Timers.ElapsedEventArgs e)
    {
        //comment
        health--;
     }
}