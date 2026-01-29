public class MyQueue {
    private Stack<int> mainQueue;
    private Stack<int> helperQueue;


    public MyQueue() {
        mainQueue = new Stack<int>();
        helperQueue = new Stack<int>();
    }
    
    public void Push(int x) {
        this.mainQueue.Push(x);
    }
    
    public int Pop() {
        int popped;
        while(this.mainQueue.Count!=0)
        {
            this.helperQueue.Push(this.mainQueue.Pop());
        }
         popped = this.helperQueue.Pop();

        while(this.helperQueue.Count!=0){
            this.mainQueue.Push(this.helperQueue.Pop());
        }
        return popped;
    }
    
    public int Peek() {
        int peeked;
        while(this.mainQueue.Count!=0)
        {
            this.helperQueue.Push(this.mainQueue.Pop());
        }
        peeked = this.helperQueue.Peek(); 

        while(this.helperQueue.Count!=0){
            this.mainQueue.Push(this.helperQueue.Pop());
        }
        return peeked;
    }
    
    public bool Empty() {
       if(this.mainQueue.Count == 0){
        return true;
       }
       else{
        return false;
       }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */