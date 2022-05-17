using System;
using System.Collections.Generic;

namespace Calc
{
    public class Parser
    {
        public Node Parse(IEnumerable<Token> tokens)
        {
            Node currentNd = null; 

            foreach(var token in tokens)
            {
                if(token.Type == TokenType.Number)
                {
                    if (currentNd == null){
                         // créer ma mon noeud (String)
                        var tmpNode = new Node();
                        tmpNode.Value = "0";
                        tmpNode.LeftChild = null;
                        tmpNode.RightChild = null;

                        // Affecte ma valeur au currentNd
                        currentNd = new Node();
                        currentNd.LeftChild = tmpNode;
                    }
                    else if(currentNd.RightChild == null && currentNd.LeftChild != null){
                        // créer ma mon noeud (String)
                        var tmpNode = new Node();
                        tmpNode.Value = "0";
                        tmpNode.LeftChild = null;
                        tmpNode.RightChild = null;

                        // 
                    }
                    else{
                        var NewNode = new Node();
                        currentNd.Value = "0";
                        currentNd.LeftChild = null;
                        currentNd.RightChild = null;

                        NewNode.LeftChild = currentNd;
                        NewNode.RightChild = NewNode;
                    }
                }

                if(token.Type == TokenType.Operator)
                {
                    currentNd.Value = token.Value;
                }
            }

            return currentNd;
        }

        // public string Value { get; set; }

        // public override bool Equals(object obj)
        // {
        //     var token = obj as Token;
        //     if (token == null) return false;

        //     return token.Type == Type && token.Value == Value;
        // }


    }
}
