using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditText : MonoBehaviour
{
    public GameObject MyCanvas;
    private GameObject _textLeft;
    private GameObject _textRight;
    public Font TheChosenFont;
    private Text _textLeftRef;
    private Text _textRightRef;
    private RectTransform _textLeftRect;
    private RectTransform _textRightRect;
    private const string NewLine = "\r\n";
    private const string _TheGroupTitle = "Group:";
    private const string _TheGroupName = "The Yahoos (not affiliated with yahoo.com)";
    private const string _TheAssestsTitle = "Assets Used: " + NewLine + NewLine + NewLine;
    private const string _TheAssets = "https://3dtextures.me/2017/12/06/wood-plancks-005/" + NewLine +
                           "https://3dtextures.me/2017/12/02/tiles-008/ " + NewLine + 
                           "https://unity3d.com/learn/tutorials/s/roll-ball-tutorial" + NewLine +
                           "http://www.1001fonts.com/kobarapi-font.html#character-map";
    private const string _TheGroupMembersTitle = "Group Members: " + NewLine + NewLine + NewLine;
    private const string _TheGroupMembers = "Adrian Kwok " + NewLine +
                           "Bernie Cervantes " + NewLine + 
                           "Matthew Hess"; 

    void Start()
    {
        //procedurally generated 
        _textLeft = new GameObject("Text Left", typeof(Text));
        _textRight = new GameObject("Text Right", typeof(Text));
        _textLeftRef = _textLeft.GetComponent<Text>();
        _textRightRef = _textRight.GetComponent<Text>();
        _textLeftRect = _textLeft.GetComponent<RectTransform>();
        _textRightRect = _textRight.GetComponent<RectTransform>();
        var leftStrings = new string[20];
        var rightStrings = new string[20];

        leftStrings[0] = _TheGroupTitle;
        rightStrings[0] = _TheGroupName;
        leftStrings[1] = _TheAssestsTitle;
        rightStrings[1] = _TheAssets;
        leftStrings[2] = _TheGroupMembersTitle;
        rightStrings[2] = _TheGroupMembers;

        for (var i = 0; i < 3; i++)
        {
            _textLeftRef.text += leftStrings[i] + NewLine;
            _textRightRef.text += rightStrings[i] + NewLine;
        }
            
        // TextLeft.transform.parent = this.transform; // Get clarification
        _textLeft.transform.SetParent(MyCanvas.transform);
        _textRight.transform.SetParent(MyCanvas.transform);
        _textLeftRef.color = Color.HSVToRGB(0f, 255.0f, 199f);
        _textRightRef.color = Color.HSVToRGB(0f, 255.0f, 199f);
        _textLeftRef.font = TheChosenFont;
        _textRightRef.font = TheChosenFont;
        _textLeftRef.fontStyle = FontStyle.Bold;
        _textRightRef.fontStyle = FontStyle.Bold;
        _textLeftRef.lineSpacing = 4;
        _textRightRef.lineSpacing = 4f;
        _textLeftRef.fontSize = 19;
        _textRightRef.fontSize = 19;
        _textLeftRect.localPosition = new Vector3(-200f,-500f,0);
        _textRightRect.localPosition = new Vector3(120f, -500f, 0);
        
        //Set Rect
        _textLeftRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,200f);
        _textLeftRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 900f);
        _textRightRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 800f);
        _textRightRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 900f);
    }

    void Update()
    {
        _textLeftRect.localPosition += Vector3.up;
        _textRightRect.localPosition += Vector3.up;
        if (Time.fixedTime == 18f)
            SceneManager.LoadScene("Intro");
    }
}
