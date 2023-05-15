using Metin_Yazari_Belirleme.Sınıflar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Yazari_Belirleme
{
    public class Heap : IHeap
    {
        private HeapNode[] heapArray { get; set; }

        private int maxSize { get; set; }

        private int currentSize { get; set; }

        public Heap(int maxSize)
        {
            this.maxSize = maxSize;
            heapArray = new HeapNode[maxSize];
            currentSize = 0;
        }
        public bool Insert(KelimeKullanim value)
        {
            if (currentSize == maxSize)
                return false;
            HeapNode newHeapDugumu = new HeapNode(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Value.kullanimSayisi < bottom.Value.kullanimSayisi)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public HeapNode RemoveMax()
        {
            HeapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;

                if (rightChild < currentSize &&
                heapArray[leftChild].Value.kullanimSayisi < heapArray[rightChild].Value.kullanimSayisi)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Value.kullanimSayisi >= heapArray[largerChild].Value.kullanimSayisi)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public KelimeKullanim[] Sort()
        {
            KelimeKullanim[] sorted = new KelimeKullanim[maxSize];
            int i = 0;
            while (!IsEmpty())
                sorted[i++] = RemoveMax().Value;
            return sorted;
        }
    }
}
