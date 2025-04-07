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
    public string NameDialog { get; set; }
    public bool Read { get; set; }
    public DialogStyle StyleOfDialog { get; set; }
    public List<StepBranch> StepBranches { get; set; } = new List<StepBranch>();
    public BigPicture[] BigPicturesPresets { get; set; } = new BigPicture[0];
    public bool MoreRead { get; set; }
    public bool CanMove { get; set; }
    public bool CanInter { get; set; }
    public float MainPanelStartDelay { get; set; }
    public string FastChangesName { get; set; }
    public bool DarkAfterEnd { get; set; }
    public int ActivateCutsceneStepAfterEnd { get; set; } = -1;

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
        NameDialog = nameDialog;
    }

    public StepBranch GetBranchByName(string name)
    {
        foreach (StepBranch branch in StepBranches)
        {
            if (branch.BranchName == name)
                return branch;
        }

        return null;
    }
}

public class StepBranch
{
    public string BranchName { get; set; }
    public List<DialogStep> DialogSteps { get; set; } = new List<DialogStep>();
    public List<DialogChoice> Choices { get; set; } = new List<DialogChoice>();

    public StepBranch()
    {
    }

    public StepBranch(string name)
    {
        BranchName = name;
    }

    public DialogStep GetDialogStepByName(string name)
    {
        foreach (DialogStep step in DialogSteps)
        {
            if (step.StepName == name)
                return step;
        }

        return null;
    }
}

public class DialogStep
{
    public string StepName { get; set; }
    public string TotalNpcName { get; set; }
    public LanguageSetting DialogText { get; set; }
    public string BigPictureName { get; set; }
    public bool CursedText { get; set; }
    public float DelayAfterNext { get; set; }
    public int ActivateCutsceneStep { get; set; } = -1;
    public string FastChangesName { get; set; }

    public DialogStep()
    {
    }

    public DialogStep(string name)
    {
        StepName = name;
    }
}

public class DialogChoice
{
    public string NameNewBranch { get; set; }
    public bool Read { get; set; }
    public LanguageSetting TextQuestion { get; set; }
    public bool MoreRead { get; set; }
}

public class BigPicture
{
    public string BigPictureName { get; set; }
}

// Просто так
public class LanguageSetting
{
    public string ru { get; set; }
    public string en { get; set; }

    public LanguageSetting()
    {
        ru = "";
        en = "";
    }
    
    public LanguageSetting(string russianText, string englishText)
    {
        ru = russianText;
        en = englishText;
    }
}