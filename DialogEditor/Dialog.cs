namespace DialogEditor;
using System.Collections.Generic;

public class Dialog
{
    public string nameDialog;
    public bool read;

    public DialogStyle styleOfDialog;

    public enum DialogStyle
    {
        Main,
        SubMain,
        BigPicture
    };

    public List<StepBranch> stepBranches = new List<StepBranch>();
    
    public BigPicture[] bigPicturesPresets = new BigPicture[0];
    public bool moreRead;
    public bool canMove, canInter;
    public float mainPanelStartDelay; // Задержка перед появлением

    public string fastChangesName;
    public bool darkAfterEnd;
    //public Transform posAfterEnd;
    public int activateCutsceneStepAfterEnd = -1;
}

public class StepBranch
{
    public string branchName;
    public DialogStep[] dialogSteps = new DialogStep[0];
    public DialogChoice[] choices = new DialogChoice[0];
}

public class DialogStep
{
    public static string totalNpcName;

    public LanguageSetting dialogText;
    public string bigPictureName;

    //public Transform cameraTarget;
    public bool cursedText;
    public float delayAfterNext;
    public int activateCutsceneStep = -1;
    public string fastChangesName;
}

public class DialogChoice
{
    public string nameNewBranch;
    public bool read;
    public LanguageSetting textQuestion;

    public bool moreRead;
}


public class BigPicture
{
    public string bigPictureName;
    //public Sprite[] sprites = new Sprite[0];
}