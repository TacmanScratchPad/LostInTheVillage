﻿using System.Collections;
using TMPro;
using UnityEngine;

public enum Place_enum
{
    Welcome_Village2,
    Bar1,
    Bar2,
    Roszkol1,
    Roszkol2,
    Orzel_welcome,
    Orzel_glasses,
    Orzel_tunel,
    Orzel_laptop,
    Village1,
    Village1Man,
}

public class CharacterMessage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI destination;
    public Place_enum place;
    public AudioSource BGM;

    public static bool isMusicDown = false;

    [SerializeField] private AudioClip Welcome_Village2_PL;
    [SerializeField] private AudioClip Welcome_Village2_EN;
    [SerializeField] private AudioClip Welcome_Village2_GER;
    [SerializeField] private AudioClip Welcome_Village2_SPA;

    [SerializeField] private AudioClip Bar1_PL;
    [SerializeField] private AudioClip Bar1_EN;
    [SerializeField] private AudioClip Bar1_GER;
    [SerializeField] private AudioClip Bar1_SPA;

    [SerializeField] private AudioClip Bar2_PL;
    [SerializeField] private AudioClip Bar2_EN;
    [SerializeField] private AudioClip Bar2_GER;
    [SerializeField] private AudioClip Bar2_SPA;

    [SerializeField] private AudioClip Roszkol1_PL;
    [SerializeField] private AudioClip Roszkol1_EN;
    [SerializeField] private AudioClip Roszkol1_GER;
    [SerializeField] private AudioClip Roszkol1_SPA;

    [SerializeField] private AudioClip Roszkol2_PL;
    [SerializeField] private AudioClip Roszkol2_EN;
    [SerializeField] private AudioClip Roszkol2_GER;
    [SerializeField] private AudioClip Roszkol2_SPA;

    [SerializeField] private AudioClip Orzel_welcome_PL;
    [SerializeField] private AudioClip Orzel_welcome_EN;
    [SerializeField] private AudioClip Orzel_welcome_GER;
    [SerializeField] private AudioClip Orzel_welcome_SPA;

    [SerializeField] private AudioClip Orzel_glasses_PL;
    [SerializeField] private AudioClip Orzel_glasses_EN;
    [SerializeField] private AudioClip Orzel_glasses_GER;
    [SerializeField] private AudioClip Orzel_glasses_SPA;

    [SerializeField] private AudioClip Orzel_tunel_PL;
    [SerializeField] private AudioClip Orzel_tunel_EN;
    [SerializeField] private AudioClip Orzel_tunel_GER;
    [SerializeField] private AudioClip Orzel_tunel_SPA;

    [SerializeField] private AudioClip Orzel_laptop_PL;
    [SerializeField] private AudioClip Orzel_laptop_EN;
    [SerializeField] private AudioClip Orzel_laptop_GER;
    [SerializeField] private AudioClip Orzel_laptop_SPA;

    [SerializeField] private AudioClip Village1_PL;
    [SerializeField] private AudioClip Village1_EN;
    [SerializeField] private AudioClip Village1_GER;
    [SerializeField] private AudioClip Village1_SPA;

    [SerializeField] private AudioClip Village1Man_PL;
    [SerializeField] private AudioClip Village1Man_EN;
    [SerializeField] private AudioClip Village1Man_GER;
    [SerializeField] private AudioClip Village1Man_SPA;

    private string str_Welcome_Village2_PL = "Ahh te okropne miasto. Jak widzisz pojawiły się wrogie roboty. Tylko Orzeł może nas uratować. Ostatni raz widziałem go w domu alkoholików. To jest na ulicy Cichej 4";
    private string str_Welcome_Village2_EN = "Ahh this horrible city. As you can see, hostile robots have appeared. Only the Eagle can save us. The last time I saw him was at an alcoholic's home. This is on Quiet 4 Street";
    private string str_Welcome_Village2_GER = "Ahh, diese schreckliche Stadt. Wie Sie sehen können, sind feindliche Roboter aufgetaucht. Nur der Adler kann uns retten. Das letzte Mal, dass ich ihn sah, war bei einem Alkoholiker zu Hause. Es liegt in der Ruhige-Straße 4.";
    private string str_Welcome_Village2_SPA = "Ahh esta horrible ciudad. Como puede ver, han aparecido robots hostiles. Sólo el Águila puede salvarnos. La última vez que lo vi fue en la casa de un alcohólico. Esto es en la calle Tranquila 4";

    private string str_Bar1_PL = "Witaj w moim barze! Jasne, że wiem, gdzie może być orzeł, ale najpierw musisz spróbować mojego wina.";
    private string str_Bar1_EN = "Welcome to my bar! Sure, I know where the eagle might be, but first you have to taste my wine.";
    private string str_Bar1_GER = "Willkommen in meiner Bar! Klar, ich weiß, wo der Adler sein könnte, aber zuerst musst du meinen Wein probieren.";
    private string str_Bar1_SPA = "¡Bienvenido a mi bar! Claro, sé dónde podría estar el águila, pero primero tienes que probar mi vino.";

    private string str_Bar2_PL = "Mam nadzieję, że smakowało. Roszkol może wiedzieć, gdzie jest Orzeł. Mieszka on przy ulicy Parkowej 4. Wpadnij jeszcze do mnie na wyższe piętra.";
    private string str_Bar2_EN = "I hope it tasted good. Roszkol may know where the Eagle is. He lives at 4 Parks Street. Come and visit me sometimes on the upper floors.";
    private string str_Bar2_GER = "Ich hoffe, es hat gut geschmeckt. Roszkol weiß vielleicht, wo der Adler ist. Er wohnt in der Parkstraße 4. Besuchen Sie mich manchmal in den oberen Etagen.";
    private string str_Bar2_SPA = "Espero que supiera bien. Roszkol puede saber dónde está el Águila. Vive en la calle Parque 4. Ven a visitarme a los pisos superiores.";

    private string str_Roszkol1_PL = "Witam serdecznie w moich skromnych progach. Szukasz Orła? Zaraz ci powiem, gdzie mieszka, ale najpierw proszę, nakarm mojego psa. Śpi gdzieś na łóżku.";
    private string str_Roszkol1_EN = "Welcome to my humble home. Looking for an Eagle? I'll tell you where he lives in a minute, but first, please, feed my dog. He's sleeping on a bed somewhere.";
    private string str_Roszkol1_GER = "Willkommen in meinem bescheidenen Zuhause. Auf der Suche nach einem Adler? Ich werde Ihnen gleich sagen, wo er wohnt, aber zuerst füttern Sie bitte meinen Hund. Er schläft irgendwo auf einem Bett.";
    private string str_Roszkol1_SPA = "Bienvenidos a mi humilde hogar. ¿Buscas un águila? Te diré dónde vive en un minuto, pero primero, por favor, alimenta a mi perro. Está durmiendo en una cama en alguna parte.";

    private string str_Roszkol2_PL = "Dzięki wielkie za usługę. Orzeł jest przy ulicy Namiotowej 21. Powodzenia!";
    private string str_Roszkol2_EN = "Thanks a lot for the service. The eagle is at 21 Tent Street. Good luck!";
    private string str_Roszkol2_GER = "Vielen Dank für den Service. Der Adler befindet sich in der Zeltstraße 21. Viel Glück!";
    private string str_Roszkol2_SPA = "Muchas gracias por el servicio. El águila está en Tent Street 21. ¡Buena suerte!";

    private string str_Orzel_welcome_PL = "Siema! Ale wczoraj zachlałem! Trzeba jak najszybciej wyłączyć te roboty, ale na PWR zgubiłem okulary. Chodźmy jak najszybciej ich poszukać!";
    private string str_Orzel_welcome_EN = "Hiya! I have a big hangover! We need to disable these robots as soon as possible, but I lost my glasses at PWR. Let's go look for them as soon as possible!";
    private string str_Orzel_welcome_GER = "Hallo! Ich habe einen großen Kater! Wir müssen diese Roboter so schnell wie möglich außer Gefecht setzen, aber ich habe meine Brille bei PWR verloren. Lasst uns so schnell wie möglich nach ihnen suchen!";
    private string str_Orzel_welcome_SPA = "¡Hola! ¡Tengo una gran resaca! Necesitamos desactivar estos robots lo antes posible, pero perdí mis anteojos en PWR. ¡Vamos a buscarlos lo antes posible!";

    private string str_Orzel_glasses_PL = "O, dziękuję bardzo, ale na Politechnice zalało serwery. Trzeba jak najszybciej włączyć kopię zapasową. Włącznik znajduje się w tunelu przy ulicy Cichej, między pierwszym a drugim domem.";
    private string str_Orzel_glasses_EN = "Oh, thank you very much, but the servers at the University of Technology were flooded. You need to enable backup as soon as possible. The switch is in the tunnel on Quiet Street, between the first and second house.";
    private string str_Orzel_glasses_GER = "Oh, vielen Dank, aber die Server der Technischen Universität waren überlastet. Sie müssen die Sicherung so schnell wie möglich aktivieren. Der Schalter befindet sich im Tunnel in der Ruhige-Straße, zwischen dem ersten und zweiten Haus.";
    private string str_Orzel_glasses_SPA = "Oh, muchas gracias, pero los servidores de la Universidad Tecnológica se inundaron. Debe habilitar la copia de seguridad lo antes posible. El interruptor está en el túnel de la calle Tranquila, entre la primera y la segunda casa.";

    private string str_Orzel_tunel_PL = "Trochę tu ciemno, chodźmy do parku.";
    private string str_Orzel_tunel_EN = "It's a little dark in here, let's go to the park.";
    private string str_Orzel_tunel_GER = "Es ist etwas dunkel hier drin, lass uns in den Park gehen.";
    private string str_Orzel_tunel_SPA = "Está un poco oscuro aquí, vamos al parque.";

    private string str_Orzel_laptop_PL = "Bug został naprawiony błyskawicznie. Nareszcie mogę opuścić te miasto. Odprowadź mnie do bram miasta.";
    private string str_Orzel_laptop_EN = "The bug was fixed quickly. I can finally leave this town. Walk me to the city gates.";
    private string str_Orzel_laptop_GER = "Der Fehler wurde schnell behoben. Endlich kann ich diese Stadt verlassen. Begleite mich zu den Toren der Stadt.";
    private string str_Orzel_laptop_SPA = "El error se solucionó rápidamente. Finalmente puedo dejar esta ciudad. Llévame a las puertas de la ciudad.";

    private string str_Village1_PL = "Budzisz się przez hałas w twojej spokojnej wiosce. Idź do centrali i dowiedz się, co się stało.";
    private string str_Village1_EN = "You wake up to the noise in your peaceful village. Go to headquarters and find out what happened";
    private string str_Village1_GER = "Sie wachen mit dem Lärm in Ihrem friedlichen Dorf auf. Gehen Sie zum Zentral und finden Sie heraus, was passiert ist.";
    private string str_Village1_SPA = "Te despiertas con el ruido de tu tranquilo pueblo. Ve a la sede y averigua qué pasó.";

    private string str_Village1Man_PL = "Jakiś nieodpowiedzialny programista postanowił powierzyć całą swoją pracę Chatowi GPT i puścił nieprzetestowany kod na produkcję. Teraz pojawiły się wrogie roboty. Musisz iść do miasta 'Orzeł', tam jest programista, który może nas uratować.";
    private string str_Village1Man_EN = "Some irresponsible programmer decided to delegate all of their work to Chatbot GPT and released untested code into production. Now hostile robots have appeared. You must go to the town of 'Orzeł,' there is a programmer who can save us.";
    private string str_Village1Man_GER = "Ein verantwortungsloser Programmierer hat beschlossen, seine gesamte Arbeit dem Chatbot GPT zu überlassen und ungetesteten Code in die Produktion zu bringen. Jetzt sind feindliche Roboter aufgetaucht. Du musst in die Stadt 'Orzeł' gehen, dort ist ein Programmierer, der uns retten kann.";
    private string str_Village1Man_SPA = "Un programador irresponsable decidió delegar todo su trabajo en el Chatbot GPT y lanzó código no probado a producción. Ahora han aparecido robots hostiles. Debes ir a la ciudad 'Orzeł', allí hay un programador que puede salvarnos.";

    private string str2_Welcome_Village2_PL = "Cicha 4";
    private string str2_Welcome_Village2_EN = "Quiet 4 Street";
    private string str2_Welcome_Village2_GER = "Ruhige-Straße 4";
    private string str2_Welcome_Village2_SPA = "calle Tranquila 4";

    private string str2_Bar1_PL = "Napij się wina ze stolika";
    private string str2_Bar1_EN = "Drink some wine";
    private string str2_Bar1_GER = "Trink etwas Wein";
    private string str2_Bar1_SPA = "Toma un poco de vino";

    private string str2_Bar2_PL = "Parkowa 4";
    private string str2_Bar2_EN = "4 Parks Street";
    private string str2_Bar2_GER = "Parkstraße 4";
    private string str2_Bar2_SPA = "la calle Parque 4";

    private string str2_Roszkol1_PL = "Pies na łóżku";
    private string str2_Roszkol1_EN = "The dog on the bed";
    private string str2_Roszkol1_GER = "Der Hund auf dem Bett";
    private string str2_Roszkol1_SPA = "El perro en la cama";

    private string str2_Roszkol2_PL = "Namiotowa 21";
    private string str2_Roszkol2_EN = "21 Tent Street";
    private string str2_Roszkol2_GER = "Zeltstraße 21";
    private string str2_Roszkol2_SPA = "Tent Street 21";

    private string str2_Orzel_welcome_PL = "PWR - Niemiecka";
    private string str2_Orzel_welcome_EN = "PWR - German";
    private string str2_Orzel_welcome_GER = "PWR - Deutsche Straße";
    private string str2_Orzel_welcome_SPA = "PWR - calle alemana";

    private string str2_Orzel_glasses_PL = "tunel przy ulicy Cichej między pierwszym a drugim domem";
    private string str2_Orzel_glasses_EN = "the tunnel on Quiet Street, between the first and second house";
    private string str2_Orzel_glasses_GER = "Tunnel in der Ruhige-Straße, zwischen dem ersten und zweiten Haus";
    private string str2_Orzel_glasses_SPA = "el túnel de la calle Tranquila, entre la primera y la segunda casa";

    private string str2_Orzel_tunel_PL = "Laptop w Parku";
    private string str2_Orzel_tunel_EN = "Laptop in the Park";
    private string str2_Orzel_tunel_GER = "Laptop im Park";
    private string str2_Orzel_tunel_SPA = "Laptop en el parque";

    private string str2_Orzel_laptop_PL = "Bramy miasta";
    private string str2_Orzel_laptop_EN = "City gates";
    private string str2_Orzel_laptop_GER = "Stadttore";
    private string str2_Orzel_laptop_SPA = "puertas de la ciudad";

    private string str2_Village1_PL = "Centrala";
    private string str2_Village1_EN = "headquarters";
    private string str2_Village1_GER = "Zentral";
    private string str2_Village1_SPA = "la sede";

    private string str2_Village1Man_PL = "Bramy wioski";
    private string str2_Village1Man_EN = "Gates of the village";
    private string str2_Village1Man_GER = "Tore des Dorfes";
    private string str2_Village1Man_SPA = "Puertas del pueblo";

    public AudioClip audio;
    private string promptString;
    private string destinationString;

    private Transform cameraTransform;
    private Quaternion initialRotation;
    private bool isRotating = false;
    private float rotationSpeed = 2f;
    private Animator animator;

    void Start()
    {
        GameObject mainCamera = GameObject.FindWithTag("MainCamera");
        if (mainCamera != null)
        {
            cameraTransform = mainCamera.transform;
        }
        initialRotation = transform.rotation;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isMusicDown)
        {
            if (cameraTransform != null)
            {
                Vector3 lookDirection = cameraTransform.position - transform.position;
                lookDirection.y = 0f;

                Quaternion targetRotation = Quaternion.LookRotation(lookDirection.normalized, transform.up);
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            }
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, rotationSpeed * Time.deltaTime);

            if (Quaternion.Angle(transform.rotation, initialRotation) < 1f)
            {
                transform.rotation = initialRotation;
                isRotating = false;
            }
        }
    }

    public void Message()
    {
        Select();

        destination.text = destinationString;

        ChangeBGM(audio);
        if (!(place == Place_enum.Village1))
        {
            StartCoroutine(waitingFun(audio.length));
        }
        else
        {
            StartCoroutine(waitingFunVillage(audio.length));
        }
    }

    IEnumerator waitingFun(float time1)
    {
        isMusicDown = true;
        promptText.text = promptString;
        animator.SetBool("is_talk", true);
        yield return new WaitForSeconds(time1);
        animator.SetBool("is_talk", false);

        yield return new WaitForSeconds(1.0f);

        if (place == Place_enum.Bar1)
        {
            GoToWine gotowine = GetComponent<GoToWine>();
            gotowine.MoveToDestination();
        }
        else if (place == Place_enum.Bar2)
        {
            GoToWine gotowine = GetComponent<GoToWine>();
            gotowine.MoveToDestination2();
        }

        else if (place == Place_enum.Orzel_welcome || place == Place_enum.Orzel_glasses || place == Place_enum.Orzel_tunel || place == Place_enum.Orzel_laptop)
        {
            GoToPlayer goToPlayer = GetComponent<GoToPlayer>();
            goToPlayer.isToGo = true;
        }
        yield return new WaitForSeconds(1.0f);
        promptText.text = "";
        isMusicDown = false;
    }

    IEnumerator waitingFunVillage(float time1)
    {
        isMusicDown = true;
        promptText.text = promptString;
        yield return new WaitForSeconds(time1);
        yield return new WaitForSeconds(2.0f);
        promptText.text = "";
        isMusicDown = false;
    }

    private void ChangeBGM(AudioClip music)
    {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }

    private void Select()
    {
        switch (place)
        {
            case Place_enum.Welcome_Village2:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Welcome_Village2_PL;
                        promptString = str_Welcome_Village2_PL;
                        destinationString = str2_Welcome_Village2_PL;
                        break;
                    case Language_enum.English:
                        audio = Welcome_Village2_EN;
                        promptString = str_Welcome_Village2_EN;
                        destinationString = str2_Welcome_Village2_EN;
                        break;
                    case Language_enum.German:
                        audio = Welcome_Village2_GER;
                        promptString = str_Welcome_Village2_GER;
                        destinationString = str2_Welcome_Village2_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Welcome_Village2_SPA;
                        promptString = str_Welcome_Village2_SPA;
                        destinationString = str2_Welcome_Village2_SPA;
                        break;
                }
                break;
            case Place_enum.Bar1:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Bar1_PL;
                        promptString = str_Bar1_PL;
                        destinationString = str2_Bar1_PL;
                        break;
                    case Language_enum.English:
                        audio = Bar1_EN;
                        promptString = str_Bar1_EN;
                        destinationString = str2_Bar1_EN;
                        break;
                    case Language_enum.German:
                        audio = Bar1_GER;
                        promptString = str_Bar1_GER;
                        destinationString = str2_Bar1_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Bar1_SPA;
                        promptString = str_Bar1_SPA;
                        destinationString = str2_Bar1_SPA;
                        break;
                }
                break;
            case Place_enum.Bar2:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Bar2_PL;
                        promptString = str_Bar2_PL;
                        destinationString = str2_Bar2_PL;
                        break;
                    case Language_enum.English:
                        audio = Bar2_EN;
                        promptString = str_Bar2_EN;
                        destinationString = str2_Bar2_EN;
                        break;
                    case Language_enum.German:
                        audio = Bar2_GER;
                        promptString = str_Bar2_GER;
                        destinationString = str2_Bar2_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Bar2_SPA;
                        promptString = str_Bar2_SPA;
                        destinationString = str2_Bar2_SPA;
                        break;
                }
                break;
            case Place_enum.Roszkol1:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Roszkol1_PL;
                        promptString = str_Roszkol1_PL;
                        destinationString = str2_Roszkol1_PL;
                        break;
                    case Language_enum.English:
                        audio = Roszkol1_EN;
                        promptString = str_Roszkol1_EN;
                        destinationString = str2_Roszkol1_EN;
                        break;
                    case Language_enum.German:
                        audio = Roszkol1_GER;
                        promptString = str_Roszkol1_GER;
                        destinationString = str2_Roszkol1_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Roszkol1_SPA;
                        promptString = str_Roszkol1_SPA;
                        destinationString = str2_Roszkol1_SPA;
                        break;
                }
                break;
            case Place_enum.Roszkol2:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Roszkol2_PL;
                        promptString = str_Roszkol2_PL;
                        destinationString = str2_Roszkol2_PL;
                        break;
                    case Language_enum.English:
                        audio = Roszkol2_EN;
                        promptString = str_Roszkol2_EN;
                        destinationString = str2_Roszkol2_EN;
                        break;
                    case Language_enum.German:
                        audio = Roszkol2_GER;
                        promptString = str_Roszkol2_GER;
                        destinationString = str2_Roszkol2_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Roszkol2_SPA;
                        promptString = str_Roszkol2_SPA;
                        destinationString = str2_Roszkol2_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_welcome:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_welcome_PL;
                        promptString = str_Orzel_welcome_PL;
                        destinationString = str2_Orzel_welcome_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_welcome_EN;
                        promptString = str_Orzel_welcome_EN;
                        destinationString = str2_Orzel_welcome_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_welcome_GER;
                        promptString = str_Orzel_welcome_GER;
                        destinationString = str2_Orzel_welcome_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_welcome_SPA;
                        promptString = str_Orzel_welcome_SPA;
                        destinationString = str2_Orzel_welcome_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_glasses:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_glasses_PL;
                        promptString = str_Orzel_glasses_PL;
                        destinationString = str2_Orzel_glasses_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_glasses_EN;
                        promptString = str_Orzel_glasses_EN;
                        destinationString = str2_Orzel_glasses_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_glasses_GER;
                        promptString = str_Orzel_glasses_GER;
                        destinationString = str2_Orzel_glasses_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_glasses_SPA;
                        promptString = str_Orzel_glasses_SPA;
                        destinationString = str2_Orzel_glasses_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_tunel:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_tunel_PL;
                        promptString = str_Orzel_tunel_PL;
                        destinationString = str2_Orzel_tunel_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_tunel_EN;
                        promptString = str_Orzel_tunel_EN;
                        destinationString = str2_Orzel_tunel_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_tunel_GER;
                        promptString = str_Orzel_tunel_GER;
                        destinationString = str2_Orzel_tunel_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_tunel_SPA;
                        promptString = str_Orzel_tunel_SPA;
                        destinationString = str2_Orzel_tunel_SPA;
                        break;
                }
                break;
            case Place_enum.Orzel_laptop:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Orzel_laptop_PL;
                        promptString = str_Orzel_laptop_PL;
                        destinationString = str2_Orzel_laptop_PL;
                        break;
                    case Language_enum.English:
                        audio = Orzel_laptop_EN;
                        promptString = str_Orzel_laptop_EN;
                        destinationString = str2_Orzel_laptop_EN;
                        break;
                    case Language_enum.German:
                        audio = Orzel_laptop_GER;
                        promptString = str_Orzel_laptop_GER;
                        destinationString = str2_Orzel_laptop_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Orzel_laptop_SPA;
                        promptString = str_Orzel_laptop_SPA;
                        destinationString = str2_Orzel_laptop_SPA;
                        break;
                }
                break;
            case Place_enum.Village1:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Village1_PL;
                        promptString = str_Village1_PL;
                        destinationString = str2_Village1_PL;
                        break;
                    case Language_enum.English:
                        audio = Village1_EN;
                        promptString = str_Village1_EN;
                        destinationString = str2_Village1_EN;
                        break;
                    case Language_enum.German:
                        audio = Village1_GER;
                        promptString = str_Village1_GER;
                        destinationString = str2_Village1_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Village1_SPA;
                        promptString = str_Village1_SPA;
                        destinationString = str2_Village1_SPA;
                        break;
                }
                break;
            case Place_enum.Village1Man:
                switch (Language.language)
                {
                    case Language_enum.Polish:
                        audio = Village1Man_PL;
                        promptString = str_Village1Man_PL;
                        destinationString = str2_Village1Man_PL;
                        break;
                    case Language_enum.English:
                        audio = Village1Man_EN;
                        promptString = str_Village1Man_EN;
                        destinationString = str2_Village1Man_EN;
                        break;
                    case Language_enum.German:
                        audio = Village1Man_GER;
                        promptString = str_Village1Man_GER;
                        destinationString = str2_Village1Man_GER;
                        break;
                    case Language_enum.Spain:
                        audio = Village1Man_SPA;
                        promptString = str_Village1Man_SPA;
                        destinationString = str2_Village1Man_SPA;
                        break;
                }
                break;
        }
    }
}
