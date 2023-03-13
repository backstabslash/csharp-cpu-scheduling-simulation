https://user-images.githubusercontent.com/71657988/224712437-649b08f6-aceb-4b52-a19e-db82363f44b9.mp4

TECHNICAL TASK

It is necessary to create a simulation model of the operating system and implement the following points:

• Generation of processes with the appropriate characteristics specified at the start of the model;

• Process scheduler with HPF algorithm based on an array of queues (simplified hashing);

• Device schedulers;

• Device queues;

• Memory and memory scheduler;

• Graphical user interface with the ability to set the initial system settings and display statistics.

DESCRIPTION OF THE DEVELOPED CLASSES

CPU

This class has two fields: a resource (Resource) and a queue of ready processes (IQueueable<Process>). It also has a Session method, which implements the HPF scheduling algorithm based on an array of queues (simplified hashing): the process with the highest priority is taken from the queues of ready actions.

QUEUE OF READY PROCESSES

In the implemented model for storing and interacting with processes, the QueueArray class was created, in which a FIFO (first in - first out) array was declared, in which processes fell depending on the value of their Priority field, which, in turn, was assigned to them randomly in the range from 0 to MaxPriority when they are created; “MaxPriority” is set by the user when working with the model (but not more than 20).

The processor got the process from the queue with the highest priority, but not any one, but the one that arrived in the queue before the others.

RESOURCE

The resource class acts as the device that the process hits. That is. the objects of this class are the central processing unit and external devices. Every cycle, the WorkingCycle method is called for all devices, which, in turn, calls the IncreaseWorkTime method for the processes located on them. If there are none, this cycle device is idle.

PROCESS

The process class contains the fields: sequence number or id (int), name (String), execution time (int), amount of memory allocated for it (int), time worked on the device (int) and the corresponding priority field. The process also has a status field, which can take the following urgent values:

• ready – the process is waiting to be placed on the CPU;

• running – the process is running on the processor or one of the external devices;

• waiting – the process is waiting for one of the external devices;

• terminated – the process has completed and is ready to be deleted.

This class also implements the IncreaseWorkTime method. During its call, it is checked whether the process has completed on the device. If so, the process randomly selects its status: either it queues up for one of the external devices, or it finishes its job. Otherwise, the time worked on the device is incremented.

SETTINGS

At its core, this class describes the future characteristics of all actions. Before running the model, the user selects the values of the settings assigned to the corresponding properties: the frequency of occurrence of new processes (double), the minimum and maximum time spent on the device (int), the minimum and maximum value of the required memory (int), the maximum priority (int), and the size RAM of the model itself (int)

MEMORY

Before starting the simulation, the user specifies the amount of model memory. This value is stored in the storage class. When a process is added to one of the queues, the memory occupied by this process is taken away from the total memory. This value is also a class field.

If the amount of free memory is less than the amount of memory needed to execute a new process, this process becomes the so-called rejected process: it does not fall into any of the queues.

MODEL

The main class of the system: almost all other classes of the model are implemented in it. It has the following fields: work cycle counter (SystemClock), processor (Resouce), external devices (Resource), RAM (Memory), queue of ready processes (IQueueble<Process>), queues to external devices (IQueueble<Process>), scheduler processor (CPUScheduler), memory scheduler (MemoryManager), external device schedulers (DeviceScheduler), model settings (Settings) and statistics (Statistics).

This class implements the WorkingCycle method: a method that simulates the operation of the operating system. It calls the method for sorting the queue of ready processes, generates new processes, increments clock cycles, calls the WorkingCycle methods of the processor and external devices.

Also in the Model class, the FreeingAResourceEventHandler event handler is implemented, which, depending on the status of the process, puts or removes it from the device.
