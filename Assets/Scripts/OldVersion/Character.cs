// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public enum Statistic
// {
//     Life,
//     Damage,
//     Armor,
//     AttackSpeed
// }
// [Serializable]
// public class StatsValue
// {
//     public Statistic statisticType;
//     public bool typeFloat;
//     public int integer_value;
//     public float float_value;


//     public StatsValue(Statistic statisticType, int value = 0)
//     {
//         this.statisticType = statisticType;
//         this.integer_value = value;
//     }
//         public StatsValue(Statistic statisticType, float float_value)
//     {
//         this.statisticType = statisticType;
//         this.float_value = float_value;
//         typeFloat = true;

//     }
// }
// [Serializable]
// public class StatsGroup
// {
//     public List<StatsValue> stats;
//     public StatsGroup()
//     {
//         stats= new List<StatsValue>();        
//     }
//     public void Init()
//     {
//         stats.Add(new StatsValue(Statistic.Life, 100));
//         stats.Add(new StatsValue(Statistic.Damage, 25));
//         stats.Add(new StatsValue(Statistic.Armor, 5));
//         stats.Add(new StatsValue(Statistic.AttackSpeed, 1f));
//     }

//     internal StatsValue Get(Statistic statisticToGet)
//     {
//         return stats[(int)statisticToGet];
//     }
// }
// public enum Attribute
// {
//     Strenght,
//     Velocity,
//     Intelligence
// }

// [Serializable]
// public class AttributeValue
// {
//     public Attribute attributeType;
//     public int value;

//     public AttributeValue(Attribute attributeType, int value = 0)
//     {
//         this.attributeType = attributeType;
//         this.value = value;
//     }
// }

// [Serializable]
// public class AttributeGroup
// {
//     public List<AttributeValue> attributeValues;

//     public AttributeGroup()
//     {
//         attributeValues = new List<AttributeValue>();
                
//     }
//     public void Init()
//     {
//         attributeValues.Add(new AttributeValue(Attribute.Strenght));
//         attributeValues.Add(new AttributeValue(Attribute.Velocity));
//         attributeValues.Add(new AttributeValue(Attribute.Intelligence));
//     }
// }

// public class ValuePool
// {
//     public StatsValue maxValue;
//     public int currentValue;
//     public ValuePool(StatsValue maxValue)
//     {
//         this.maxValue = maxValue;
//         this.currentValue = maxValue.integer_value;
//     }
// }
// public class Character : MonoBehaviour
// {
//     [SerializeField] AttributeGroup attributes;
//     [SerializeField] StatsGroup stats;
//     public ValuePool lifePool;

    

//     // Start is called before the first frame update
//     void Start()
//     {
//         attributes = new AttributeGroup();
//         attributes.Init();
//         stats = new StatsGroup();
//         stats.Init();
//         StatsValue lifeStat = stats.Get(Statistic.Life);
//         lifePool = new ValuePool(lifeStat);
//     }

//     public void TakeDamage(int damage)
//     {
//         damage = ApplyDefence(damage);

//         lifePool.currentValue -= damage;

//         Debug.Log(lifePool.currentValue.ToString());

//         CheckDeath();
//     }

//     private int ApplyDefence(int damage)
//     {
//         damage -= stats.Get(Statistic.Armor).integer_value;

//         if (damage <= 0)
//         {
//             damage = 0;
//         }

//         return damage;
//     }

//     private void CheckDeath()
//     {
//         if (lifePool.currentValue <= 0)
//         {
//             Debug.Log("Dead");
//         }
//     }

//     public StatsValue TakeStats(Statistic statisticToGet)
//     {
//         return stats.Get(statisticToGet);
//     }
// }