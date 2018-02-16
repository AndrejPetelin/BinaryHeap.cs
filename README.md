# BinaryHeap.cs
Binary Heap implementation in C#

A binary heap, see https://en.wikipedia.org/wiki/Binary_heap , implementation using C#'s System.Collections.Generic List as data storage.

Elements must implement IComparable in order to be sorted, also provides overloaded constructor that takes a delegate function object as argument in order to accomodate for different sorting order.

Note: pop and peek functions will throw IndexOutOfRangeException if called on empty heap.


# Usage:

```
// create a binary heap of ints
BinaryHeap<int> pq = new BinaryHeap<int>();


// add element to the heap
pq.push(42);

// remove top element from the heap
int topElt = pq.pop();


// create a binary heap, ordered in reverse (largest element on top)
BinaryHeap<int> reversePq = new BinaryHeap<int>((x, y) => { return y.CompareTo(x); });
```
