//1

//async Task ProcessOrderAsync(int orderId)
//{
//    Console.WriteLine($"Заказ {orderId}: начал обработку");

//    await Task.Delay(2000);

//    Console.WriteLine($"Заказ {orderId}: обработка завершена");

//}

//await Task.WhenAll(ProcessOrderAsync(1), ProcessOrderAsync(2), ProcessOrderAsync(3));

//2

//int counter = 0;

//object _lock = new object();

//Thread thread_1 = new Thread(
//    () =>
//    {

//        for (int i = 0; i < 1000; i++)
//        {
//            lock (_lock)
//            {
//                counter++;

//            }
//        }
//    });

//Thread thread_2 = new Thread(
//    () =>
//    {
//        for (int i = 0; i < 1000; i++)
//        {
//            lock (_lock)
//            {
//                counter++;

//            }
//        }
//    });

//Thread thread_3 = new Thread(
//    () =>
//    {
//        for (int i = 0; i < 1000; i++)
//        {
//            lock (_lock)
//            {
//                counter++;

//            }
//        }
//    });

//Thread thread_4 = new Thread(
//    () =>
//    {
//        for (int i = 0; i < 1000; i++)
//        {
//            lock (_lock)
//            {
//                counter++;

//            }
//        }
//    });

//Thread thread_5 = new Thread(
//    () =>
//    {
//        for (int i = 0; i < 1000; i++)
//        {
//            lock (_lock)
//            {
//                counter++;

//            }
//        }
//    });

//thread_1.Start();
//thread_2.Start();
//thread_3.Start();
//thread_4.Start();
//thread_5.Start();


//thread_1.Join();
//thread_2.Join();
//thread_3.Join();
//thread_4.Join();
//thread_5.Join();


//Console.WriteLine(counter);