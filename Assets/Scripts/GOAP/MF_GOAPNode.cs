using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum ETest
{
    test0,
    test1
}

public static class MF_GOAPNode
{
    // Changeable
    public class GoalNode<TL>
    {
        // enum type
        public readonly Dictionary<TL, bool> link;
        public readonly int valueWorth;
        
        //public GoalNode(TL goal, bool)
            

    }

    // Only copyable
    public class ConditionNode<TF, TB>
    {
        // enum type
        private Dictionary<TF, bool> frontLink;
        private Dictionary<TB, bool> backLink;
        private int valueWorth;

        public Dictionary<TF, bool> FrontLink => frontLink;
        public Dictionary<TB, bool> BackLink => backLink;
        public int ValueWorth => valueWorth;
        

        public ConditionNode(TF frontCondition, bool trueOrFalse0, TB backCondition, bool trueOrFalse1, int valueWorth)
        {
            frontLink = new Dictionary<TF, bool> {{frontCondition, trueOrFalse0}};
            backLink = new Dictionary<TB, bool> {{backCondition, trueOrFalse1}};
            this.valueWorth = valueWorth;
        }

        public void addFront(Dictionary<TF, bool> toAddFront)
        {
            toAddFront.ToList().ForEach(x => frontLink.Add(x.Key, x.Value));
        }

        public void addBack(Dictionary<TB, bool> toAddBack)
        {
            toAddBack.ToList().ForEach(x => backLink.Add(x.Key, x.Value));
        }

        public void changeValueWorth(int valueWorth)
        {
            this.valueWorth = valueWorth;
        }
    }
    
    // public static GoalNode<Type> operator == (ConditionNode<Type, Type> )
    // {
    //     throw new NotImplementedException();
    // }
    
}
