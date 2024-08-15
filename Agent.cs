

public class Agent {
    public int id;

    public Settlement parentSettlement;

    public Agent(int passed_id, Settlement settlement){
        id = passed_id;
        parentSettlement = settlement;
    }
}
