using DialogEditor;

public class DialogCollection
{
    public List<Dialog> Dialogs { get; set; }

    public DialogCollection()
    {
        Dialogs = new List<Dialog>();
    }
}

public class Dialog
{
    // Всё с маленьких букв для лучшего импорта
    public string nameDialog { get; set; }
    public bool read { get; set; }
    public DialogStyle styleOfDialog { get; set; }
    public List<StepBranch> stepBranches { get; set; } = new List<StepBranch>();
    public BigPicture[] bigPicturesPresets { get; set; } = new BigPicture[0];
    public bool moreRead { get; set; }
    public bool canMove { get; set; }
    public bool canInter { get; set; }
    public float mainPanelStartDelay { get; set; }
    public bool darkAfterEnd { get; set; }

    public enum DialogStyle
    {
        Main,
        SubMain,
        BigPicture
    }

    public Dialog()
    {
    }

    public Dialog(string nameDialog)
    {
        this.nameDialog = nameDialog;
    }

    public StepBranch GetBranchByName(string name)
    {
        foreach (StepBranch branch in stepBranches)
        {
            if (branch.branchName == name)
                return branch;
        }

        return null;
    }
}

public class StepBranch
{
    public string branchName { get; set; }
    public List<DialogStep> dialogSteps { get; set; } = new List<DialogStep>();
    public List<DialogChoice> choices { get; set; } = new List<DialogChoice>();

    public StepBranch()
    {
    }

    public StepBranch(string name)
    {
        branchName = name;
    }

    public DialogStep GetDialogStepByName(string name)
    {
        foreach (DialogStep step in dialogSteps)
        {
            if (step.stepName == name)
                return step;
        }

        return null;
    }
    
    public DialogChoice GetDialogChoiceByName(string name)
    {
        foreach (DialogChoice choice in choices)
        {
            if (choice.choiceName == name)
                return choice;
        }

        return null;
    }
}

public class DialogStep
{
    public string stepName { get; set; }
    public string totalNpcName { get; set; }
    public LanguageSetting dialogText { get; set; }
    public IconMood iconMoodSelected { get; set; }
    public string bigPictureName { get; set; }
    public bool cursedText { get; set; }
    public float delayAfterNext { get; set; }
    public int activateCutsceneStep { get; set; } = -1;
    public FastChangesController fastChanges { get; set; }

    public DialogStep()
    {
    }

    public DialogStep(string name)
    {
        stepName = name;
    }
}

public class DialogChoice
{
    public string choiceName;
    public string nameNewBranch { get; set; }
    public bool read { get; set; }
    public LanguageSetting textQuestion { get; set; }
    public bool moreRead { get; set; }

    public DialogChoice(string nameNewBranch)
    {
        choiceName = nameNewBranch;
    }
}

public class BigPicture
{
    public string bigPictureName { get; set; }
}

public enum IconMood
{
    Standart,
    Happy,
    Angry,
    Sad,
    Scary,
    Wonder, // Непонимание
    Confusion, // Удивление
    Curse
}