using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private bool hasFindImage;
    public GameObject initCanvas;
    public GameObject welcomePlayer;
    public GameObject walkPlayer;
    public GameObject CanvasMenu;
    private int isFirstWelcome = 1;

    public static bool contentPlay = false;

    private int contentPlayNum = 1;

    public static int number = 0;
    private Text text;

    public static bool resume = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hasFindImage = ImageTargetController.FindImage;
        if (hasFindImage && isFirstWelcome > 0)
        {
            welcomePlayer.SetActive(true);
            isFirstWelcome--;
            playAudio.playWelcomeMusic = true;
            initCanvas.SetActive(false);
        }
        if (contentPlay && contentPlayNum > 0)
        {
            contentPlayNum--;
            contentPlay = false;
            walkPlayer.SetActive(true);
            CanvasMenu.SetActive(true);
            playContentAudio.playContentMusic = true;
            if (number ==1)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video1.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = "唐车长27.5厘米，高20.5厘米；牛高7厘米，长17厘米\n1960年陕西省铜川市耀州区出土\n这套牛车施翠绿色釉，釉色晶莹。车厢为长方形，前有帘，顶为半圆形篷盖。牛肥壮，足短而粗，双角直立，神态自然生动。\n唐人除乘马车外，亦习用牛车,如唐李寿墓、阿史那忠墓、李震墓壁画中都有牛车图，文献中亦不乏朝官、妇女使用犊车的记载。";
            }
            if (number == 2)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video2.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = "明\n高25.5厘米，\n1952年征集\n侍俑头戴边鼓帽, 着褐色及膝窄袖袍, 袍外罩翻领对襟短袖衫, 双手捧巾于胸前, 表情谦卑而严肃。\n明代王公贵族墓中随葬的大量陶俑均成组出现,包括列队仪仗、诸班仆役等,五代、宋、元长期消失的仪仗俑群在明代再度出现,是这一时期陶俑的一个显著特点。";
            }
            if (number == 3)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video3.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = "西汉\n1972年陕西省蒲城县出土\n玉雕卧牛是在一整块呈黑色的玉料上，采用圆雕的技法琢制而成。这件玉牛代表了汉代圆雕工艺的高超水平，工匠们抓住了卧牛的动态特点，用流畅简洁的线条表现四肢的动态，静中有动。";
            }
            if (number == 4)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video4.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = "陶楼，魏晋，高31cm，长36cm。  通体施绿釉，有剥蚀，屋顶正中有方形口，四角饰小熊，两侧有孔，四周有墙，瓦顶有瓦垄，前有瓦当，屋檐四角各有六云纹瓦当，中间一层一周有五人，前边有门，后边有方窗，两侧有圆窗，四周有围栏，最下方形底座四面有窗棱。";
            }
            if (number == 5)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video5.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = " “和同开珎”银币是日本奈良王朝元明天皇和铜元年（相当于唐中宗景龙二年，公元708年）仿效中国唐代“开元通宝”钱铸造的货币。它从始铸到停废仅一年三个月，所以铸量不多，现在日本国内也存量有限。何家村窖藏中一次出土了五枚银质“和同开珎”。经考证是唐玄宗开元四年（716年）日本第七次遣唐使带入中国的";
            }
            if (number == 6)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video6.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = "唐代的农牧业十分发达，特别是养马业最为兴盛。据资料记载高宗麟德年间仅官方养马就达七十万六千匹，这是在古代国家养马的最高数字。唐代马的用途非常广泛，无论作战、运输还是狩猎等，都离不开马。唐人爱马，马在动物形象中被塑造的最为成功，艺术家们抓住了马的神情，用内在的劲而发外在的形，生气盎然，栩栩如生。";
            }
            if (number == 7)
            {
                VideoData.videoNum = "http://47.94.110.199:9980/video7.mp4";
                text = GameObject.Find("CanvasMenu/Panel/Text").GetComponent<Text>();
                text.text = "这件是白玉忍冬纹八曲长杯。用和田美玉雕凿而成，玉质洁白温润，玉杯外壁装饰有忍冬图案。忍冬纹又称为卷草纹，是一种缠绕植物，因为在冬天也不凋谢，故有忍冬之称，是从南北朝就开始流行的一种装饰纹样，。《本草纲目》中记载：忍冬“久服轻身，长年益寿”，因此用它来寓意长寿。";
            }
        }

    }

    public void visitWeb()
    {
        WWW a = new WWW("www.baidu.com");

        Application.OpenURL(a.url);
    }

    public void playVideo()
    {
        SceneManager.LoadScene("VideoPlayer");
    }

    public void Resume()
    {
        playContentAudio.playContentMusic = false;
        playAudio.playWelcomeMusic = false;


        CanvasMenu.SetActive(false);
        walkPlayer.SetActive(false);

        ImageTargetController.FindImage = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
