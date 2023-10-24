using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public Text explain;
    const int cnt = 8;
    string[] explainText = new string[cnt];
    float time = 0;
    int drawCnt = 0;

    private bool[] Keyinput;
    private float[] Stickinput;

    public Text totitle;
    // Start is called before the first frame update
    void Start()
    {
        explainText[0] = "���X�e�B�b�N�iL�X�e�B�b�N�j�ŔL�i�v���C���[�j�ړ��I\n";
        explainText[1] = "�E�X�e�B�b�N�iR�X�e�B�b�N�j�ŃJ�����ړ��I\n";
        explainText[2] = "RB�{�^���ō�(�e)�𔭎ˁB���i�G�j��ǂ������I\n";
        explainText[3] = "LB�{�^���ŉ��ʂ𔭎ˁB������ԑŐs�I\n�L�����Ď��g���H����Ă��܂��I\n";
        explainText[4] = "wave���ƂɌ��������ς�����̂Œǂ��������I\n�ǂ��������Ƃ��ɃR�C�����o�邩�炽������W�߂悤�I\n";
        explainText[5] = "�R�C������������W�߂������������I�����傳��ɖJ�߂Ă��炨���I\n";
        explainText[6] = "�_���[�W��H����Ă��܂��ƁA�R�C���𗎂Ƃ��āA\n�ꎞ�I�ɍ����łĂȂ��Ȃ��Ă��܂����I\n";
        explainText[7] = "����̔L�̍���A���ʂł��_���[�W��H����Ă��܂����I\n";

        totitle.text = "START�{�^����\n�^�C�g����";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        KeyChack();
        bool BKey = Input.GetButtonDown("buttonB");

        if (BKey)
        {
            explain.text = explainText[drawCnt % cnt];
            drawCnt++;
        }

        if (time >= 5.0f)
        {
            time = 0;
            explain.text = explainText[drawCnt%cnt];
            drawCnt++;
        }

        

        if (Input.GetButtonDown("Start"))
        {
            Initiate.Fade("title", Color.black, 1.0f);
        }
    }

    private void KeyChack()
    {       
        
    }
}
