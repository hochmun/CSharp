﻿/*
2023/07/21 // 대리자 체인 예시

실행 결과
Listener1.SomethingHappend : You've got mail.
Listener2.SomethingHappend : You've got mail.
Listener3.SomethingHappend : You've got mail.

Listener1.SomethingHappend : Download complete.
Listener3.SomethingHappend : Download complete.

Listener2.SomethingHappend : Nuclear launch detected.
Listener3.SomethingHappend : Nuclear launch detected.

Listener1.SomethingHappend : Fire!!
Listener2.SomethingHappend : Fire!!

Listener1.SomethingHappend : RPG!
 */
namespace DelegateChains
{
    // Notify 대리자 선언
    delegate void Notify(string message);

    // Notify 대리자의 인스턴스
    // EventOccured를 가지는 클래스 Notifier 선언
    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;

        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            // += 연산자를 이용한 체인 만들기
            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            // -= 연산자를 이용한 체인 끊기
            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download complete.");

            Console.WriteLine();

            // +, = 연산자를 이용한 체인 만들기
            notifier.EventOccured = new Notify(listener2.SomethingHappend)
                + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            // Delegate.Combine() 메소드를 이용한 체인 만들기
            notifier.EventOccured =
                (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!!");

            Console.WriteLine();

            // Delegate.Remove() 메소드를 이용한 체인 끊기
            notifier.EventOccured =
                (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!");
        }
    }
}