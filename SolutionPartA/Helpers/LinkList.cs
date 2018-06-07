using System;
namespace SolutionPartA.Helpers
{
    public class LinkList
    {
        private LinkedListItem Head { get; set; }
        private LinkedListItem Current { get; set; }

        public int Count { get; private set; }

        public LinkList()
        {
            Head = new LinkedListItem();
            Current = Head;
        }

        public void AddAtLast(int item){
            LinkedListItem newItem = new LinkedListItem();
            newItem.Number = item;
            newItem.Previous = Current;
            newItem.Next = newItem;
            Current = newItem;
            Count++;
        }

        public void AddAtFirst(int item)
        {
            LinkedListItem newItem = new LinkedListItem();
            newItem.Number = item;
            newItem.Previous = Head;
            newItem.Next = Head;
            Head = newItem;
            Count++;
        }

        public LinkedListItem GetItemWithIndex(int index){
            int counter = index;
            LinkedListItem cursor = new LinkedListItem();
            while(counter > 0){
                cursor = Current;
                Current = cursor.Previous;
                counter--;
            }
            return cursor;
        }
    }
}
