SELECT Tietokoneet.Id, 
GPU.Sarja, GPU.GraphicsCard, GPU_ID,
CPU.Merkki, CPU.Prosessori, CPU.Cores, CPU.Threads, CPU.ClockSpeedGHZ, CPU_Id,
MOBO.Merkki, MOBO.Malli, MOBO_ID,
RAM.Merkki, RAM.ClockSpeedMHZ, RAMamount, RAM_ID,
CCase.Merkki, CCase.Malli, Case_ID,
PSU.Merkki, PSU.Malli, PSU.Teho, PSU_ID
FROM Tietokoneet
INNER JOIN GPU ON Tietokoneet.GPU_ID=GPU.Id
INNER JOIN CPU ON Tietokoneet.CPU_ID=CPU.Id
INNER JOIN MOBO ON Tietokoneet.MOBO_ID=MOBO.Id
INNER JOIN RAM ON Tietokoneet.RAM_ID=RAM.Id
INNER JOIN CCase ON Tietokoneet.Case_ID=CCase.Id
INNER JOIN PSU ON Tietokoneet.PSU_ID=PSU.Id;