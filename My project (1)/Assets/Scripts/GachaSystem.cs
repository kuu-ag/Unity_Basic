using System.Collections.Generic;
using UnityEngine;

public class GachaSystem : MonoBehaviour
{
    string pickupS = "칼로소";

    List<string> sGrade = new List<string> { "카인", "힐더", "디레지에", "미카엘라", "카시야스" };
    List<string> aGrade = new List<string> { "이시스-프레이", "시로코", "안톤", "로터스", "루크", "오즈마" };
    List<string> bGrade = new List<string> { "카론", "어비스의 근원", "모로스", "우시르", "레미디오스", "베누스" };
    List<string> cGrade = new List<string> { "카잔", "브레멘", "사야", "케이가", "라사", "칼라", "블라슈", "지그" };

    void Start()
    {
        TenPull();
    }

    public void TenPull()
    {
        Debug.Log("10연차 뽑기 결과");

        bool gotAOrHigher = false;

        for (int i = 0; i < 10; i++)
        {
            bool forceAOrHigher = (i == 9 && !gotAOrHigher);
            string result = DrawCharacter(forceAOrHigher);

            if (result.StartsWith("[S") || result.StartsWith("[A"))
                gotAOrHigher = true;

            Debug.Log($"{i + 1}번째 결과는 → {result}");
        }
    }

    string DrawCharacter(bool forceAOrHigher = false)
    {
        int randomValue = Random.Range(1, 101);

        if (forceAOrHigher && randomValue > 10) 
        {
            randomValue = Random.Range(1, 11);
        }

        if (randomValue <= 3)
        {
            int pickupChance = Random.Range(1, 101);
            if (pickupChance <= 50)
                return $"[PICK UP] {pickupS}";
            else
                return $"[S] {sGrade[Random.Range(0, sGrade.Count)]}";
        }
        else if (randomValue <= 10)
        {
            return $"[A] {aGrade[Random.Range(0, aGrade.Count)]}";
        }
        else if (randomValue <= 30)
        {
            return $"[B] {bGrade[Random.Range(0, bGrade.Count)]}";
        }
        else
        {
            return $"[C] {cGrade[Random.Range(0, cGrade.Count)]}";
        }
    }
}