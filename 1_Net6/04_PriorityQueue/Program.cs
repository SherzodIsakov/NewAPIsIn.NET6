//PriorityQueue представляет собой очередь с минимальным приоритетом.
//Каждый элемент ставится в очередь с соответствующим приоритетом, который определяет порядок удаления из очереди.
//Элементы с наименьшим номером удаляются из очереди первыми.


PriorityQueue<string, int> priorityQueue = new();

priorityQueue.Enqueue("Second", 2);
priorityQueue.Enqueue("Fourth", 4);
priorityQueue.Enqueue("Third 1", 3);
priorityQueue.Enqueue("Third 2", 3);
priorityQueue.Enqueue("First", 1);

while (priorityQueue.Count > 0)
{
    string item = priorityQueue.Dequeue();
    Console.WriteLine(item);
}
Console.ReadKey();

// Output:
// First
// Second
// Third 2
// Third 1
// Fourth
