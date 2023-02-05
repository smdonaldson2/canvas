namespace Instructor;
public class Professor
{
    string name;
    double pay_rate;
    int id_number;
    string department;

    public string getName() {return name;}

    public int getProfID() {return id_number;}

    public string getDept() {return department;}

    public void changePayRate(double newRate) {pay_rate = newRate;}

    



}
