using UnityEngine;
using MidiJack;

public class NoteIndicator : MonoBehaviour
{
    public int noteNumber;
    public Color initColor;
    private InGameManager inGameMgr = null;

    private void Awake()
    {
        initColor = this.GetComponent<Renderer>().material.color;
        inGameMgr = InGameManager.instance;
    }

    void Update()
    {
        if (MidiMaster.GetKeyDown(noteNumber))
        {
            inGameMgr.triggerAni.SetNextAniByTrigger();
        }

        //float a = MidiMaster.GetKey(noteNumber);

        //if (a > 0)
        //{
        //    Debug.Log(string.Format("{0}, {1}",noteNumber, MidiMaster.GetKey(noteNumber)));
        //}

        Color _color = initColor;
        if (MidiMaster.GetKey(noteNumber) > 0.0f)
        {
            switch (noteNumber % 12)
            {
                case 0: //C
                    _color = new Color(1, 0, 2.0f / 3.0f);
                    break;
                case 1: //C#
                    _color = new Color(1, 0, 1.0f / 3.0f);
                    break;
                case 2: //D
                    _color = new Color(1, 1.0f / 3.0f, 0);
                    break;
                case 3: //D#
                    _color = new Color(1, 2.0f / 3.0f, 0);
                    break;
                case 4: //E
                    _color = new Color(2.0f / 3.0f, 1, 0);
                    break;
                case 5: //F
                    _color = new Color(1.0f / 3.0f, 1, 0);
                    break;
                case 6: //F#
                    _color = new Color(0, 1, 1.0f / 3.0f);
                    break;
                case 7: //G
                    _color = new Color(0, 1, 2.0f / 3.0f);
                    break;
                case 8: //G#
                    _color = new Color(0, 2.0f / 3.0f, 1);
                    break;
                case 9: //A
                    _color = new Color(0, 1.0f / 3.0f, 1);
                    break;
                case 10: //A#
                    _color = new Color(1.0f / 3.0f, 0, 1);
                    break;
                case 11: //B
                    _color = new Color(2.0f / 3.0f, 0, 1);
                    break;
            }
        }


        this.GetComponent<Renderer>().material.color = _color;
    }
}
