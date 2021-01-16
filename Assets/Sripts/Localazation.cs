using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Localazation : MonoBehaviour
{
    public Text[] labels;
    public Font[] fonts;
    public Text[] TutorialLabels;
    public Text[] TutorialEditor;

    public void Awake()
    {
        if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
        {
            labels[0].text = "玩";
            labels[1].text = "玩";
            labels[2].text = "等级";
            labels[3].text = "等级";
            labels[4].text = "设定";
            labels[5].text = "设定";
            labels[6].text = "输出值";
            labels[7].text = "输出值";
            labels[8].text = "设定";
            labels[9].text = "设定";
            labels[10].text = "下一阶段的明星";
            labels[11].text = "下一阶段的明星";
            labels[12].text = "重播";
            labels[13].text = "重播";
            labels[10].resizeTextForBestFit = true;
            labels[10].fontSize = 14;
            labels[11].resizeTextForBestFit = true;
            labels[11].fontSize = 14;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialLabels[0].text = "您好，这是很小的，但是您可以通过详细的帮助来了解它的本质";
            TutorialLabels[1].text = "您好，这是很小的，但是您可以通过详细的帮助来了解它的本质";
            TutorialLabels[2].text = "首先，我告诉您您的目标是什么." +
                "您需要打破锯上的坠落小球并收集星星，星星负责发现以下级别的困难";
            TutorialLabels[3].text = "首先，我告诉您您的目标是什么." +
                "您需要打破锯上的坠落小球并收集星星，星星负责发现以下级别的困难";
            TutorialLabels[4].text = "平台，三角形和圆形的对象将在此帮助.";
            TutorialLabels[5].text = "平台，三角形和圆形的对象将在此帮助.";
            TutorialLabels[6].text = "即将推出可改善游戏流程的创新";
            TutorialLabels[7].text = "即将推出可改善游戏流程的创新";
            TutorialLabels[8].text = "让我们在学习游戏的过程中顺利进行 :)";
            TutorialLabels[9].text = "让我们在学习游戏的过程中顺利进行 :)";
            for (int i = 0; i < TutorialLabels.Length; i++)
            {
                TutorialLabels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialEditor[0].text = "好，让我们开始";
            TutorialEditor[1].text = "好，让我们开始";
            TutorialEditor[2].text = "按下继续";
            TutorialEditor[3].text = "按下继续";
            TutorialEditor[4].text = "对象块";
            TutorialEditor[5].text = "对象块";
            TutorialEditor[6].text = "这是一个对象块，您可以将其放置在布局区域中，为通往立方锯的道路铺平道路.";
            TutorialEditor[7].text = "这是一个对象块，您可以将其放置在布局区域中，为通往立方锯的道路铺平道路.";
            TutorialEditor[8].text = "按下继续";
            TutorialEditor[9].text = "按下继续";
            TutorialEditor[10].text = "明星柜台";
            TutorialEditor[11].text = "明星柜台";
            TutorialEditor[12].text = "按下继续";
            TutorialEditor[13].text = "按下继续";
            TutorialEditor[14].text = "这是跟踪您的星级进展的星级计数器";
            TutorialEditor[15].text = "这是跟踪您的星级进展的星级计数器";
            TutorialEditor[16].text = "开始和删除按钮";
            TutorialEditor[17].text = "开始和删除按钮";
            TutorialEditor[18].text = "按下按钮后，“开始”开始播放并关闭编辑器屏幕";
            TutorialEditor[19].text = "按下按钮后，“开始”开始播放并关闭编辑器屏幕";
            TutorialEditor[20].text = "按下按钮 “删除” 后，打开删除功能，然后可以删除放置的对象并单击它们";
            TutorialEditor[21].text = "按下按钮 “删除” 后，打开删除功能，然后可以删除放置的对象并单击它们";
            TutorialEditor[22].text = "按下继续";
            TutorialEditor[23].text = "按下继续";
            TutorialEditor[24].text = "住宿面积";
            TutorialEditor[25].text = "住宿面积";
            TutorialEditor[26].text = "按下继续";
            TutorialEditor[27].text = "按下继续";
            TutorialEditor[28].text = "暂停";
            TutorialEditor[29].text = "暂停";
            TutorialEditor[30].text = "这是按下按钮后打开暂停菜单的暂停按钮";
            TutorialEditor[31].text = "这是按下按钮后打开暂停菜单的暂停按钮";
            TutorialEditor[32].text = "按下继续";
            TutorialEditor[33].text = "按下继续";
            TutorialEditor[34].text = "好，让我们尝试";
            TutorialEditor[35].text = "好，让我们尝试";
            TutorialEditor[36].text = "按开始";
            TutorialEditor[37].text = "按开始";
            for (int i = 0; i < TutorialEditor.Length; i++)
            {
                TutorialEditor[i].font = fonts[1];
            }
        }

        else if (Application.systemLanguage == SystemLanguage.German)
        {
            labels[0].text = "ABSPIELEN";
            labels[1].text = "ABSPIELEN";
            labels[2].text = "STUFEN";
            labels[3].text = "STUFEN";
            labels[4].text = "DIE EINSTELLUNGEN";
            labels[5].text = "DIE EINSTELLUNGEN";
            labels[6].text = "AUSFAHRT";
            labels[7].text = "AUSFAHRT";
            labels[8].text = "DIE EINSTELLUNGEN";
            labels[9].text = "DIE EINSTELLUNGEN";
            labels[10].text = "STERNE ZUR NÄCHSTEN STUFE";
            labels[11].text = "STERNE ZUR NÄCHSTEN STUFE";
            labels[12].text = "Wiederholung";
            labels[13].text = "Wiederholung";
            labels[10].resizeTextForBestFit = true;
            labels[10].fontSize = 14;
            labels[11].resizeTextForBestFit = true;
            labels[11].fontSize = 14;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialLabels[0].text = "Hallo, das ist klein, aber detailliertes Lernen mit Hilfe Sie werden verstehen, was das Wesentliche ist";
            TutorialLabels[1].text = "Hallo, das ist klein, aber detailliertes Lernen mit Hilfe Sie werden verstehen, was das Wesentliche ist";
            TutorialLabels[2].text = "Zuerst werde ich Ihnen sagen, was Ihr Ziel ist." +
                "SIE MÜSSEN DIE FALLENDEN WÜRFEL AUF DER SÄGE BRECHEN UND DIE STERNE SAMMELN. DIE STERNE SIND FÜR DIE ENTDECKUNG DER FOLGENDEN SCHWIERIGKEITEN DER EBENEN VERANTWORTLICH";
            TutorialLabels[3].text = "Zuerst werde ich Ihnen sagen, was Ihr Ziel ist." +
                "SIE MÜSSEN DIE FALLENDEN WÜRFEL AUF DER SÄGE BRECHEN UND DIE STERNE SAMMELN. DIE STERNE SIND FÜR DIE ENTDECKUNG DER FOLGENDEN SCHWIERIGKEITEN DER EBENEN VERANTWORTLICH";
            TutorialLabels[4].text = "Objekte in Form einer Plattform, eines Dreiecks und eines Kreises helfen dabei.";
            TutorialLabels[5].text = "Objekte in Form einer Plattform, eines Dreiecks und eines Kreises helfen dabei.";
            TutorialLabels[6].text = "BALD EINFÜHREN VON NACHRICHTEN, DIE DEN SPIELPROZESS VERBESSERN.";
            TutorialLabels[7].text = "BALD EINFÜHREN VON NACHRICHTEN, DIE DEN SPIELPROZESS VERBESSERN.";
            TutorialLabels[8].text = "Kommen wir zum praktischen Teil des Lernens, wo Sie das Spiel fühlen :)";
            TutorialLabels[9].text = "Kommen wir zum praktischen Teil des Lernens, wo Sie das Spiel fühlen :)";
            for (int i = 0; i < TutorialLabels.Length; i++)
            {
                TutorialLabels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialEditor[0].text = "IN ORDNUNG, LASS UNS ANFANGEN";
            TutorialEditor[1].text = "IN ORDNUNG, LASS UNS ANFANGEN";
            TutorialEditor[2].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[3].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[4].text = "OBJEKTBLOCK";
            TutorialEditor[5].text = "OBJEKTBLOCK";
            TutorialEditor[6].text = "Dies ist ein Block von Objekten, die Sie auf dem Layoutquadrat platzieren können, um den Weg zu den Würfelsägen zu ebnen.";
            TutorialEditor[7].text = "Dies ist ein Block von Objekten, die Sie auf dem Layoutquadrat platzieren können, um den Weg zu den Würfelsägen zu ebnen.";
            TutorialEditor[8].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[9].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[10].text = "STAR COUNTER";
            TutorialEditor[11].text = "STAR COUNTER";
            TutorialEditor[12].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[13].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[14].text = "Es ist ein Sternzähler, der Ihren Sternfortschritt verfolgt";
            TutorialEditor[15].text = "Es ist ein Sternzähler, der Ihren Sternfortschritt verfolgt";
            TutorialEditor[16].text = "STARTEN UND LÖSCHEN DER TASTEN";
            TutorialEditor[17].text = "STARTEN UND LÖSCHEN DER TASTEN";
            TutorialEditor[18].text = "Nachdem Sie die Taste \"START\" gedrückt haben, beginnen Sie zu spielen und schalten den Editor-Bildschirm aus";
            TutorialEditor[19].text = "Nachdem Sie die Taste \"START\" gedrückt haben, beginnen Sie zu spielen und schalten den Editor-Bildschirm aus";
            TutorialEditor[20].text = "Nachdem Sie die Taste \"LÖSCHEN\" gedrückt haben, schalten Sie die Löschfunktion ein und können die platzierten Objekte löschen. Klicken Sie auf sie";
            TutorialEditor[21].text = "Nachdem Sie die Taste \"LÖSCHEN\" gedrückt haben, schalten Sie die Löschfunktion ein und können die platzierten Objekte löschen. Klicken Sie auf sie";
            TutorialEditor[22].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[23].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[24].text = "UNTERKUNFTBEREICH";
            TutorialEditor[25].text = "UNTERKUNFTBEREICH";
            TutorialEditor[26].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[27].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[28].text = "PAUSE";
            TutorialEditor[29].text = "PAUSE";
            TutorialEditor[30].text = "Dies ist die PAUSE-Taste, nachdem Sie das PAUSE-Menü mit den Tasten geöffnet haben";
            TutorialEditor[31].text = "Dies ist die PAUSE-Taste, nachdem Sie das PAUSE-Menü mit den Tasten geöffnet haben";
            TutorialEditor[32].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[33].text = "DRÜCKEN SIE WEITER";
            TutorialEditor[34].text = "OK LASS ES UNS VERSUCHEN";
            TutorialEditor[35].text = "OK LASS ES UNS VERSUCHEN";
            TutorialEditor[36].text = "DRÜCKEN SIE, UM ZU STARTEN";
            TutorialEditor[37].text = "DRÜCKEN SIE, UM ZU STARTEN";
            for (int i = 0; i < TutorialEditor.Length; i++)
            {
                TutorialEditor[i].font = fonts[1];
            }
        }

        else if (Application.systemLanguage == SystemLanguage.Russian) 
        {
            labels[0].text = "ИГРАТЬ";
            labels[1].text = "ИГРАТЬ";
            labels[2].text = "УРОВНИ";
            labels[3].text = "УРОВНИ";
            labels[4].text = "НАСТРОЙКИ";
            labels[5].text = "НАСТРОЙКИ";
            labels[6].text = "ВЫХОД";
            labels[7].text = "ВЫХОД";
            labels[8].text = "НАСТРОЙКИ";
            labels[9].text = "НАСТРОЙКИ";
            labels[10].text = "ЗВЕЗД ДЛЯ ПЕРЕХОДА В СЛЕДУЮЩИЙ ЭТАП";
            labels[11].text = "ЗВЕЗД ДЛЯ ПЕРЕХОДА В СЛЕДУЮЩИЙ ЭТАП";
            labels[12].text = "ПЕРЕИГРАТЬ";
            labels[13].text = "ПЕРЕИГРАТЬ";
            labels[10].resizeTextForBestFit = true;
            labels[10].fontSize = 14;
            labels[11].resizeTextForBestFit = true;
            labels[11].fontSize = 14;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].font = fonts[0];
            }

            //------------------------------------------//

            TutorialLabels[0].text = "ПРИВЕТ ЭТО НЕБОЛЬШОЕ ,НО ПОДРОБНОЕ ОБУЧЕНИЕ С ПОМОЩЬЮ НЕГО ТЫ ПОЙМЕШЬ В ЧЕМ СУТЬ";
            TutorialLabels[1].text = "ПРИВЕТ ЭТО НЕБОЛЬШОЕ ,НО ПОДРОБНОЕ ОБУЧЕНИЕ С ПОМОЩЬЮ НЕГО ТЫ ПОЙМЕШЬ В ЧЕМ СУТЬ";
            TutorialLabels[2].text = "ВО-ПЕРВЫХ, РАССКАЖУ ВАМ, В ЧЕМ ВАША ЦЕЛЬ." +
                "ВАМ НУЖНО РАЗБИВАТЬ ПАДАЮЩИЕ КУБИКИ НА ПИЛЕ И СОБИРАТЬ ЗВЕЗДЫ, ЗВЕЗДЫ ОТВЕЧАЮТ ЗА ОТКРЫТИЕ СЛЕДУЮЩИХ СЛОЖНОСТЕЙ УРОВНЕЙ";
            TutorialLabels[3].text = "ВО-ПЕРВЫХ, РАССКАЖУ ВАМ, В ЧЕМ ВАША ЦЕЛЬ." +
                "ВАМ НУЖНО РАЗБИВАТЬ ПАДАЮЩИЕ КУБИКИ НА ПИЛЕ И СОБИРАТЬ ЗВЕЗДЫ, ЗВЕЗДЫ ОТВЕЧАЮТ ЗА ОТКРЫТИЕ СЛЕДУЮЩИХ СЛОЖНОСТЕЙ УРОВНЕЙ";
            TutorialLabels[4].text = "ОБЪЕКТЫ В ФОРМЕ ПЛАТФОРМЫ, ТРЕУГОЛЬНИКА И КРУГА ПОМОГУТ В ЭТОМ.";
            TutorialLabels[5].text = "ОБЪЕКТЫ В ФОРМЕ ПЛАТФОРМЫ, ТРЕУГОЛЬНИКА И КРУГА ПОМОГУТ В ЭТОМ.";
            TutorialLabels[6].text = "ВСКОРЕ ВВЕДУ НОВОВВЕДЕНИЯ, КОТОРЫЕ УСЛОЖНЯТ ИГРОВОЙ ПРОЦЕСС.";
            TutorialLabels[7].text = "ВСКОРЕ ВВЕДУ НОВОВВЕДЕНИЯ, КОТОРЫЕ УСЛОЖНЯТ ИГРОВОЙ ПРОЦЕСС.";
            TutorialLabels[8].text = "ХОРОШО ПРИСТУПИМ К ПРАКТИЧЕСКОЙ ЧАСТИ ОБУЧЕНИЯ ГДЕ ВЫ ПОЧУВСТВУЕТЕ ИГРУ :)";
            TutorialLabels[9].text = "ХОРОШО ПРИСТУПИМ К ПРАКТИЧЕСКОЙ ЧАСТИ ОБУЧЕНИЯ ГДЕ ВЫ ПОЧУВСТВУЕТЕ ИГРУ :)";
            for (int i = 0; i < TutorialLabels.Length; i++)
            {
                TutorialLabels[i].font = fonts[0];
            }

            //------------------------------------------//

            TutorialEditor[0].text = "ХОРОШО, ДАВАЙТЕ НАЧНЕМ";
            TutorialEditor[1].text = "ХОРОШО, ДАВАЙТЕ НАЧНЕМ";
            TutorialEditor[2].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[3].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[4].text = "БЛОК ОБЪЕКТОВ";
            TutorialEditor[5].text = "БЛОК ОБЪЕКТОВ";
            TutorialEditor[6].text = "Это блок объектов, которе вы можете разместить на площади для расположения, чтобы проложить дорогу к пилам для разбивания кубов.";
            TutorialEditor[7].text = "Это блок объектов, которе вы можете разместить на площади для расположения, чтобы проложить дорогу к пилам для разбивания кубов.";
            TutorialEditor[8].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[9].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[10].text = "СЧЕТЧИК ЗВЕЗД";
            TutorialEditor[11].text = "СЧЕТЧИК ЗВЕЗД";
            TutorialEditor[12].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[13].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[14].text = "ЭТО СЧЕТЧИК ЗВЕЗД, КОТОРЫЙ ОТСЛЕЖИВАЕТ ВАШ ЗВЕЗДНЫЙ ПРОГРЕСС";
            TutorialEditor[15].text = "ЭТО СЧЕТЧИК ЗВЕЗД, КОТОРЫЙ ОТСЛЕЖИВАЕТ ВАШ ЗВЕЗДНЫЙ ПРОГРЕСС";
            TutorialEditor[16].text = "КНОПКИ СТАРТ И УДАЛЕНИЕ";
            TutorialEditor[17].text = "КНОПКИ СТАРТ И УДАЛЕНИЕ";
            TutorialEditor[18].text = "ПОСЛЕ НАЖАТИЯ КНОПКИ \"НАЧАТЬ\" ВЫ НАЧИНАЕТЕ ИГРАТЬ И ВЫКЛЮЧИТЕ ЭКРАН РЕДАКТОРА";
            TutorialEditor[19].text = "ПОСЛЕ НАЖАТИЯ КНОПКИ \"НАЧАТЬ\" ВЫ НАЧИНАЕТЕ ИГРАТЬ И ВЫКЛЮЧИТЕ ЭКРАН РЕДАКТОРА";
            TutorialEditor[20].text = "ПОСЛЕ НАЖАТИЯ КНОПКИ \"УДАЛИТЬ\" ВЫ ВКЛЮЧАЕТЕ ФУНКЦИЮ УДАЛЕНИЯ И МОЖЕТЕ УДАЛИТЬ РАЗМЕЩЕННЫЕ ОБЪЕКТЫ НАЖМИТЕ НА ИХ";
            TutorialEditor[21].text = "ПОСЛЕ НАЖАТИЯ КНОПКИ \"УДАЛИТЬ\" ВЫ ВКЛЮЧАЕТЕ ФУНКЦИЮ УДАЛЕНИЯ И МОЖЕТЕ УДАЛИТЬ РАЗМЕЩЕННЫЕ ОБЪЕКТЫ НАЖМИТЕ НА ИХ";
            TutorialEditor[22].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[23].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[24].text = "ОБЛАСТЬ РАЗМЕЩЕНИЯ";
            TutorialEditor[25].text = "ОБЛАСТЬ РАЗМЕЩЕНИЯ";
            TutorialEditor[26].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[27].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[28].text = "ПАУЗА";
            TutorialEditor[29].text = "ПАУЗА";
            TutorialEditor[30].text = "ЭТО КНОПКА ПАУЗЫ ПОСЛЕ НАЖАТИЯ ВЫ ОТКРЫВАЕТЕ МЕНЮ ПАУЗЫ С КНОПКАМИ";
            TutorialEditor[31].text = "ЭТО КНОПКА ПАУЗЫ ПОСЛЕ НАЖАТИЯ ВЫ ОТКРЫВАЕТЕ МЕНЮ ПАУЗЫ С КНОПКАМИ";
            TutorialEditor[32].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[33].text = "НАЖАТЬ, ЧТОБЫ ПРОДОЛЖИТЬ";
            TutorialEditor[34].text = "ХОРОШО, ДАВАЙ ОПРОБУЕМ";
            TutorialEditor[35].text = "ХОРОШО, ДАВАЙ ОПРОБУЕМ";
            TutorialEditor[36].text = "НАЖАТЬ, ЧТОБЫ НАЧАТЬ";
            TutorialEditor[37].text = "НАЖАТЬ, ЧТОБЫ НАЧАТЬ";
            for (int i = 0; i < TutorialEditor.Length; i++)
            {
                TutorialEditor[i].font = fonts[0];
            }
        }
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            labels[0].text = "PLAY";
            labels[1].text = "PLAY";
            labels[2].text = "LEVELS";
            labels[3].text = "LEVELS";
            labels[4].text = "OPTIONS";
            labels[5].text = "OPTIONS";
            labels[6].text = "EXIT";
            labels[7].text = "EXIT";
            labels[8].text = "OPTIONS";
            labels[9].text = "OPTIONS";
            labels[10].text = "STARS TO NEXT STAGE";
            labels[11].text = "STARS TO NEXT STAGE";
            labels[12].text = "REPLAY";
            labels[13].text = "REPLAY";
            labels[10].resizeTextForBestFit = true;
            labels[10].fontSize = 14;
            labels[11].resizeTextForBestFit = true;
            labels[11].fontSize = 14;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialLabels[0].text = "HELLO THIS IS A SMALL, BUT DETAILED LEARNING WITH HELP YOU WILL UNDERSTAND WHAT IS THE ESSENCE";
            TutorialLabels[1].text = "HELLO THIS IS A SMALL, BUT DETAILED LEARNING WITH HELP YOU WILL UNDERSTAND WHAT IS THE ESSENCE";
            TutorialLabels[2].text = "FIRST, I WILL TELL YOU WHAT IS YOUR PURPOSE" +
                "YOU NEED TO BREAK THE FALLING CUBES ON THE SAW AND COLLECT THE STARS, THE STARS ARE RESPONSIBLE FOR DISCOVERING THE FOLLOWING DIFFICULTIES OF THE LEVELS";
            TutorialLabels[3].text = "FIRST, I WILL TELL YOU WHAT IS YOUR PURPOSE" +
                "YOU NEED TO BREAK THE FALLING CUBES ON THE SAW AND COLLECT THE STARS, THE STARS ARE RESPONSIBLE FOR DISCOVERING THE FOLLOWING DIFFICULTIES OF THE LEVELS";
            TutorialLabels[4].text = "OBJECTS IN THE FORM OF A PLATFORM, A TRIANGLE AND A CIRCLE WILL HELP IN THIS.";
            TutorialLabels[5].text = "OBJECTS IN THE FORM OF A PLATFORM, A TRIANGLE AND A CIRCLE WILL HELP IN THIS.";
            TutorialLabels[6].text = "INTRODUCING NEWS SOON THAT WILL IMPROVE THE GAME PROCESS.";
            TutorialLabels[7].text = "INTRODUCING NEWS SOON THAT WILL IMPROVE THE GAME PROCESS.";
            TutorialLabels[8].text = "LET'S GET WELL TO THE PRACTICAL PART OF LEARNING WHERE YOU FEEL THE GAME :)";
            TutorialLabels[9].text = "LET'S GET WELL TO THE PRACTICAL PART OF LEARNING WHERE YOU FEEL THE GAME :)";
            for (int i = 0; i < TutorialLabels.Length; i++)
            {
                TutorialLabels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialEditor[0].text = "OK Let's start";
            TutorialEditor[1].text = "OK Let's start";
            TutorialEditor[2].text = "TOUCH TO CONTINUE";
            TutorialEditor[3].text = "TOUCH TO CONTINUE";
            TutorialEditor[4].text = "BLOCK OF OBJECTS";
            TutorialEditor[5].text = "BLOCK OF OBJECTS";
            TutorialEditor[6].text = "This is Block of Objects that you can place on placeholder to make road to saws for smash cubes";
            TutorialEditor[7].text = "This is Block of Objects that you can place on placeholder to make road to saws for smash cubes";
            TutorialEditor[8].text = "TOUCH TO CONTINUE";
            TutorialEditor[9].text = "TOUCH TO CONTINUE";
            TutorialEditor[10].text = "STAR COUNTER";
            TutorialEditor[11].text = "STAR COUNTER";
            TutorialEditor[12].text = "TOUCH TO CONTINUE";
            TutorialEditor[13].text = "TOUCH TO CONTINUE";
            TutorialEditor[14].text = "THIS IS STAR COUNTER, THAT TRACK YOUR STAR PROGRESS";
            TutorialEditor[15].text = "THIS IS STAR COUNTER, THAT TRACK YOUR STAR PROGRESS";
            TutorialEditor[16].text = "START AND DEL BUTTONS";
            TutorialEditor[17].text = "START AND DEL BUTTONS";
            TutorialEditor[18].text = "AFTER PRESS TO BUTTON START YOU START PLAY AND TURN OFF EDITOR SCREEN ";
            TutorialEditor[19].text = "AFTER PRESS TO BUTTON START YOU START PLAY AND TURN OFF EDITOR SCREEN ";
            TutorialEditor[20].text = "AFTER PRESS TO DEL BUTTON YOU TURN ON DELETE FUNCTION AND CAN DELETE PLACED OBJECTS WITH CLICKS ON THEIR";
            TutorialEditor[21].text = "AFTER PRESS TO DEL BUTTON YOU TURN ON DELETE FUNCTION AND CAN DELETE PLACED OBJECTS WITH CLICKS ON THEIR";
            TutorialEditor[22].text = "TOUCH TO CONTINUE";
            TutorialEditor[23].text = "TOUCH TO CONTINUE";
            TutorialEditor[24].text = "AREA OF PLACEMENT";
            TutorialEditor[25].text = "AREA OF PLACEMENT";
            TutorialEditor[26].text = "TOUCH TO CONTINUE";
            TutorialEditor[27].text = "TOUCH TO CONTINUE";
            TutorialEditor[28].text = "PAUSE";
            TutorialEditor[29].text = "PAUSE";
            TutorialEditor[30].text = "THIS IS A PAUSE BUTTON AFTER CLICK YOU OPEN PAUSE MENU WITH BUTTONS ";
            TutorialEditor[31].text = "THIS IS A PAUSE BUTTON AFTER CLICK YOU OPEN PAUSE MENU WITH BUTTONS ";
            TutorialEditor[32].text = "TOUCH TO CONTINUE";
            TutorialEditor[33].text = "TOUCH TO CONTINUE";
            TutorialEditor[34].text = "OKAY LET'S NOW TO TRY";
            TutorialEditor[35].text = "OKAY LET'S NOW TO TRY";
            TutorialEditor[36].text = "TOUCH TO BEGIN";
            TutorialEditor[37].text = "TOUCH TO BEGIN";
            for (int i = 0; i < TutorialEditor.Length; i++)
            {
                TutorialEditor[i].font = fonts[1];
            }
        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            labels[0].text = "플레이";
            labels[1].text = "플레이";
            labels[2].text = "레벨";
            labels[3].text = "레벨";
            labels[4].text = "옵션";
            labels[5].text = "옵션";
            labels[6].text = "산출";
            labels[7].text = "산출";
            labels[8].text = "옵션";
            labels[9].text = "옵션";
            labels[10].text = "다음 단계로 가려면 별이 필요해";
            labels[11].text = "다음 단계로 가려면 별이 필요해";
            labels[12].text = "다시 하다";
            labels[13].text = "다시 하다";
            labels[10].resizeTextForBestFit = true;
            labels[10].fontSize = 14;
            labels[11].resizeTextForBestFit = true;
            labels[11].fontSize = 14;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialLabels[0].text = "안녕하세요 이것은 작지만 본질이 무엇인지 이해하는 데 도움이되는 자세한 학습";
            TutorialLabels[1].text = "안녕하세요 이것은 작지만 본질이 무엇인지 이해하는 데 도움이되는 자세한 학습";
            TutorialLabels[2].text = "먼저 귀하의 목적이 무엇인지 알려 드리겠습니다." +
                "톱에서 떨어지는 새끼를 부수고 별을 수집해야합니다. 별은 다음 수준의 난이도를 발견 할 책임이 있습니다.";
            TutorialLabels[3].text = "먼저 귀하의 목적이 무엇인지 알려 드리겠습니다." +
                "톱에서 떨어지는 새끼를 부수고 별을 수집해야합니다. 별은 다음 수준의 난이도를 발견 할 책임이 있습니다.";
            TutorialLabels[4].text = "플랫폼, 삼각형 및 원 형태의 개체가이 작업에 도움이됩니다.";
            TutorialLabels[5].text = "플랫폼, 삼각형 및 원 형태의 개체가이 작업에 도움이됩니다.";
            TutorialLabels[6].text = "곧 게임 프로세스를 개선 할 혁신을 소개합니다.";
            TutorialLabels[7].text = "곧 게임 프로세스를 개선 할 혁신을 소개합니다.";
            TutorialLabels[8].text = "게임을 느끼는 곳에서 학습의 실제적인 부분을 시작합시다 :)";
            TutorialLabels[9].text = "게임을 느끼는 곳에서 학습의 실제적인 부분을 시작합시다 :)";
            for (int i = 0; i < TutorialLabels.Length; i++)
            {
                TutorialLabels[i].font = fonts[1];
            }

            //------------------------------------------//

            TutorialEditor[0].text = "좋습니다, 시작합시다";
            TutorialEditor[1].text = "좋습니다, 시작합시다";
            TutorialEditor[2].text = "계속하려면 누르세요.";
            TutorialEditor[3].text = "계속하려면 누르세요.";
            TutorialEditor[4].text = "개체 블록";
            TutorialEditor[5].text = "개체 블록";
            TutorialEditor[6].text = "이것은 큐브 톱으로가는 길을 포장하기 위해 레이아웃 영역에 배치 할 수있는 개체 블록입니다.";
            TutorialEditor[7].text = "이것은 큐브 톱으로가는 길을 포장하기 위해 레이아웃 영역에 배치 할 수있는 개체 블록입니다.";
            TutorialEditor[8].text = "계속하려면 누르세요.";
            TutorialEditor[9].text = "계속하려면 누르세요.";
            TutorialEditor[10].text = "스타 카운터";
            TutorialEditor[11].text = "스타 카운터";
            TutorialEditor[12].text = "계속하려면 누르세요.";
            TutorialEditor[13].text = "계속하려면 누르세요.";
            TutorialEditor[14].text = "스타의 진행 상황을 추적하는 스타 카운터";
            TutorialEditor[15].text = "스타의 진행 상황을 추적하는 스타 카운터";
            TutorialEditor[16].text = "시작 및 삭제 버튼";
            TutorialEditor[17].text = "시작 및 삭제 버튼";
            TutorialEditor[18].text = " 시작 버튼을 누르면 재생이 시작되고 편집기 화면이 꺼집니다.";
            TutorialEditor[19].text = " 시작 버튼을 누르면 재생이 시작되고 편집기 화면이 꺼집니다.";
            TutorialEditor[20].text = " 삭제 버튼을 누른 후 삭제 기능을 켜고 배치 된 개체를 삭제할 수 있습니다.";
            TutorialEditor[21].text = " 삭제 버튼을 누른 후 삭제 기능을 켜고 배치 된 개체를 삭제할 수 있습니다.";
            TutorialEditor[22].text = "계속하려면 누르세요.";
            TutorialEditor[23].text = "계속하려면 누르세요.";
            TutorialEditor[24].text = "숙박 지역";
            TutorialEditor[25].text = "숙박 지역";
            TutorialEditor[26].text = "계속하려면 누르세요.";
            TutorialEditor[27].text = "계속하려면 누르세요.";
            TutorialEditor[28].text = "중지";
            TutorialEditor[29].text = "중지";
            TutorialEditor[30].text = "버튼으로 일시 정지 메뉴를 연 후의 일시 정지 버튼입니다.";
            TutorialEditor[31].text = "버튼으로 일시 정지 메뉴를 연 후의 일시 정지 버튼입니다.";
            TutorialEditor[32].text = "계속하려면 누르세요.";
            TutorialEditor[33].text = "계속하려면 누르세요.";
            TutorialEditor[34].text = "좋아, 해보자";
            TutorialEditor[35].text = "좋아, 해보자";
            TutorialEditor[36].text = "시작하려면 누르세요";
            TutorialEditor[37].text = "시작하려면 누르세요";
            for (int i = 0; i < TutorialEditor.Length; i++)
            {
                TutorialEditor[i].font = fonts[1];
            }
        }

    }
}
