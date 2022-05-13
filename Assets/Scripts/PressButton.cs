//библиотека с различными классами и функциями от Юнити3Д
using UnityEngine;
//библиотека для махинаций со сценами
using UnityEngine.SceneManagement;
//МоноБихейвиор  - базовый класс, от которого наследуются все скрипты
public class PressButton : MonoBehaviour
{
    //говорим, что есть объект pressButtun класса GameObject (он - базовый класс для всех объектов на сценах в юнити)
    public GameObject pressButton;
    //активируем объект pressButton, позиция TRUE = active 
    public void OpenMenu()
    {
        pressButton.SetActive(true);
    }
    //создаем скрипт для перемещения между сценами, инициализируя i ( i = *номер сцены*)
    public void RunButtonsByID(int i)
    {
        //если номер сцены существует в заданных пределах, то мы её выводим пользователю, тем самым перемещаясь между сценами
        //sceneCountInBuildSettings -- счетчик сцен в билде
        //SceneManager.LoadScene(i) отвечает за вывод определенной сцены
        if (i >= 1 && i <= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(i);
        }
        else
            Debug.LogError("ID scene not exist. Max count = " + (SceneManager.sceneCountInBuildSettings - 1).ToString());
        //прописываем вывод ошибки в консоль на случай появления таковых. скорее всего понадобится при дальнейшем развитии проекта, чтобы быстрее вылавливать ошибки кода
    }
}
