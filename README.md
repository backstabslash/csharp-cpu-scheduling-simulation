https://user-images.githubusercontent.com/71657988/224712437-649b08f6-aceb-4b52-a19e-db82363f44b9.mp4

TECHNICAL ASSIGNMENT

The task at hand entails crafting a simulation model for the operating system, and carrying out the following tasks:

• Generate processes that exhibit specific traits, as defined at the commencement of the model.

• Build a process scheduler that utilizes the HPF algorithm and an array of queues, leveraging simplified hashing techniques.

• Construct device schedulers, and implement device queues for seamless integration.

• Design and deploy a memory scheduler, along with a comprehensive memory management system.

• Integrate an intuitive graphical user interface, complete with customizable system settings and real-time statistical tracking capabilities.

DEVELOPED CLASSES DESCRIPTION

CPU

The CPU class comprises of two core elements: a resource component (Resource) and a ready process queue (IQueueable<Process>). In addition, it features a Session method that executes the HPF scheduling algorithm, employing an array of queues that employ simplified hashing. Under this algorithm, the CPU selects the highest priority process from the queue of ready actions.

READY PROCESS QUEUE

In the implemented model that facilitates the storage and interaction with processes, the QueueArray class was developed. This class is equipped with a FIFO (first in, first out) array that processes are placed in, depending on the value of their Priority field. This Priority value is randomly assigned to them upon their creation, and falls within the range of 0 to MaxPriority. The MaxPriority value is predetermined by the user while working with the model, but is limited to a maximum of 20.

When selecting a process from the queue of ready actions, the CPU doesn't simply pick any process. Rather, it selects the process that arrived in the queue before the others, and which holds the highest priority.

RESOURCE

The Resource class serves as the device that processes interact with, including the central processing unit and external devices. Each cycle, the WorkingCycle method is invoked for all devices, which then calls the IncreaseWorkTime method for any processes associated with them. If no processes are present, the device remains idle during this cycle.

PROCESS

The Process class is equipped with several vital fields, including a sequence number or ID (int), name (String), execution time (int), memory allocation (int), time spent on the device (int), and priority field. Additionally, the process features a status field, which can take on any of the following critical values:

• ready – the process awaits placement on the CPU;

• running – the process executes on the processor or an external device;

• waiting – the process awaits one of the external devices;

• terminated – the process has completed and is ready for deletion.

Moreover, the class integrates the IncreaseWorkTime method. When invoked, this method checks whether the process has completed on the device. If so, the process randomly selects its status, either queuing up for one of the external devices or finishing its job. If not, the time spent on the device is incremented.

SETTINGS

The Settings class at its core outlines the prospective attributes of all operations. Prior to running the model, users choose the settings assigned to corresponding properties, such as the frequency of new process occurrence (double), minimum and maximum device time (int), minimum and maximum memory allocation (int), maximum priority (int), and the size of the model's RAM (int).

MEMORY

Before commencing the simulation, users determine the amount of memory in the model, and this value is stored in the Storage class. When a process is added to one of the queues, the memory occupied by this process is subtracted from the total memory. Furthermore, this value serves as a field in the class.

If the free memory is less than the memory required to execute a new process, this process becomes a rejected process, meaning it does not fall into any of the queues.

MODEL

The Model class is the core of the system, and it nearly encompasses all other classes in the model. It contains the following fields: a SystemClock for work cycle counting, a Processor for CPU usage, external devices, RAM, a queue of ready processes (IQueueble<Process>), queues for external devices (IQueueble<Process>), a scheduler processor (CPUScheduler), a memory scheduler (MemoryManager), model settings (Settings), and statistics.

This class incorporates the WorkingCycle method, which simulates the operating system's operation. It sorts the queue of ready processes, generates new processes, increases clock cycles, and calls the WorkingCycle method for the processor and external devices.

Furthermore, the Model class has the FreeingAResourceEventHandler event handler, which puts or removes a process from the device based on its status.
