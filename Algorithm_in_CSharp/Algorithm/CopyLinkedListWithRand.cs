using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Algorithm
{
    public class Node2
    {
        public int value;
        public Node2 next;
        public Node2 rand;

        public Node2(int data)
        {
            this.value = data;
        }
    }
    internal class CopyLinkedListWithRand
    {
        public static Node2 copyLinkedListWithRand(Node2 head) {
            Dictionary<Node2, Node2> map = new Dictionary<Node2, Node2>();
            Node2 cur = head;
            while(cur != null)
            {
                map.Add(cur, new Node2(cur.value));
                cur = cur.next;
            }
            cur = head;
            while(cur != null)
            {
                //cur 老
                // map.get(cur) 新
                map.GetValueOrDefault(cur).next = map.GetValueOrDefault(cur.next);
                map.GetValueOrDefault(cur).rand = map.GetValueOrDefault(cur.rand);
                cur = cur.next;
            }
            return map.GetValueOrDefault(head);
        }
    }
}
