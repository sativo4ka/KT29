# KT29

<img width="1100" height="187" alt="{3147170C-F2B9-48DB-B6B6-9AAAE49BA3A8}" src="https://github.com/user-attachments/assets/6a7b3df6-ac48-463d-8c10-c9f8b36a73df" />
<img width="928" height="188" alt="{23F44DC5-9144-4DD1-AD8D-9E94E1C1306A}" src="https://github.com/user-attachments/assets/e3694d1c-10b4-4a84-b46b-20f538002fb8" />
<img width="582" height="306" alt="{8D7F7D70-44C4-4619-8CFE-C7FF7CA39AD1}" src="https://github.com/user-attachments/assets/f4355af3-8c7f-4b69-ad84-4211c5f70812" />

Проверка 1. Инвариантность класса:
после добавления строки Box<Animal> b = new Box<Dog>(new Dog()); в main вышла такая ошибка:
<img width="601" height="26" alt="{D5084DD2-53F3-4571-A9A4-E1E94804595E}" src="https://github.com/user-attachments/assets/5c007ee0-3e1c-4092-9d13-cde6dc66662a" />

Проверка 2. Ограничение ковариантности интерфейса:
было:

<img width="267" height="136" alt="{37AA1768-8FD0-4BDB-8B36-8F5E9E504127}" src="https://github.com/user-attachments/assets/71edeba8-2b89-4552-9282-6e1f40f1713a" />

стало:

<img width="305" height="198" alt="{137845FC-A664-4EBF-BA63-2370AC66411C}" src="https://github.com/user-attachments/assets/e30119cd-b3f3-4f43-9e43-f5c339d94138" />

вылезли такие ошибки:

<img width="950" height="41" alt="{41F29738-D365-433C-B58E-387AA44CFB09}" src="https://github.com/user-attachments/assets/ed64eb12-226d-4307-9ed9-e76283df3d52" />
