using UnityEngine;

public class Health : MonoBehaviour
{
  public float maxHP;
  [SerializeField] float currentHP;

  void Start() => currentHP = maxHP;

  public void MinusHP(float amount) => currentHP -= amount;
  public void PlusHP(float amount) => currentHP += amount;
}
