namespace DialogEditor;

public class FastChangesController
{
    public class ChangeRelationship
    {
        public string npcName { get; set; }
        public float valueChange { get; set; }

        public ChangeRelationship()
        {
        }

        public ChangeRelationship(string name, float value)
        {
            npcName = name;
            valueChange = value;
        }
    }

    public string activateDialog { get; set; }

    public string moveToLocation { get; set; }
    public string moveToLocationSpawn { get; set; }

    public bool lockAllMenu { get; set; }

    public bool blockPlayerMove { get; set; }
    public bool blockPlayerMoveZ { get; set; }

    public List<string> addItem { get; set; }
    public List<string> addNote { get; set; }
    public List<ChangeRelationship> changeRelationships { get; set; }
}