public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

namespace Algorithm_in_CSharp.Leetcode
{

    public class AddTwoNumbers {
        public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
            int tensDigit = 0;
            ListNode rootNode = null;
            ListNode preNode = null;
            while(l1!= null || l2 != null || tensDigit != 0){
                int sum = 0;
                
                if(l1 != null){
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 != null){
                    sum += l2.val;
                    l2 = l2.next;
                }

                sum += tensDigit;
                
                tensDigit = sum / 10; // 17 / 10 = 1
                int unitDigit = sum - tensDigit * 10; // 17 - 1 * 10 = 7

                ListNode newNode = new ListNode(unitDigit);
                if(rootNode == null){
                    rootNode = newNode;
                    preNode = newNode;
                }else{
                    preNode.next = newNode;
                    preNode = newNode;
                }
            }
            return rootNode;
        }
    }
}