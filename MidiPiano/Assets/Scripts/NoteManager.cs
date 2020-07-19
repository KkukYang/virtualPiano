using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public Transform tmPianoImage;
    public Transform tm3dPianoGroup;
    public const int initNumber = 21;

    private void Awake()
    {
        tm3dPianoGroup = tmPianoImage.Find("3dPianoGroup");
    }

    // Start is called before the first frame update
    void Start()
    {
        int _addNum = 0;
        foreach(Transform _tmOctave in tm3dPianoGroup)
        {
            for(int i = 0; i<_tmOctave.childCount; i++)
            {
                NoteIndicator _note = _tmOctave.GetChild(i).gameObject.AddComponent<NoteIndicator>();
                _note.noteNumber = initNumber + _addNum++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
