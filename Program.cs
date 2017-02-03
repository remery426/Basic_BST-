using System;

namespace ConsoleApplication
{
    public class Program
    {
    public class Node
        {
        public int val { get; set; }
         public Node left { get; set; }
         public Node right { get; set; }

        public Node(int value)
        {
            val = value;
   
        }
    }
    public class BST
        {
         public Node Root { get; set; }
        
    public BST(Node my_root){
        Root = my_root;
        }
    public void Add(int val){
        var runner = this.Root; 
        while(runner!=null){
            if (runner.val>val){
                if (runner.left != null){
                    runner = runner.left;
                }
                else{
                    runner.left = new Node(val);
                    break;
                }
            }
            else{
                if(runner.right!=null){
                    runner = runner.right;
                }
                else{
                    runner.right = new Node(val);
                    break;
                }
            }
            }
        }
        public Boolean is_valid_call(){
            if(this.Root == null){
                return true;
            }
            return is_valid(this.Root,-100000,100000);
        }
        public Boolean is_valid(Node this_node, int min, int max){
            if(this_node==null){
                return true;
            }
            else if(this_node.val<=min || this_node.val>=max){
                return false;
            }
            return is_valid(this_node.left,min,this_node.val) && is_valid(this_node.right,this_node.val,max);

            
        }
        public int sizehelper(){

            return size(this.Root);
        }
        public int size(Node this_node){
            if(this_node==null){
                return 0;
            }

            return 1+size(this_node.left)+size(this_node.right);
        }
        public int Max(){
            if(this.Root==null){
                return 0;
            }
            var runner = this.Root;
            while(runner.right!=null){
                runner = runner.right;
            }
            return runner.val;

        }
        public int min(){
            if(this.Root==null){
                return 0;
            }
            var runner = this.Root;
            while(runner.left!=null){
                runner = runner.left;
            }
            return runner.val;

        }
        
        
        
        public static void Main(string[] args)
        {
            var my_node = new Node(25);
            var my_bst = new BST(my_node);
            my_bst.Add(13);
            my_bst.Add(400);
            my_bst.Add(10);
            my_bst.Add(15);
            my_bst.Add(26);
            if(my_bst.is_valid_call()){
                Console.WriteLine("yeeehawwww!");
            };
            Console.WriteLine(my_bst.sizehelper());
            Console.WriteLine(my_bst.min());

    }
}
}
}
