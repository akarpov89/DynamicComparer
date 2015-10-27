// ***** Competition: Start   *****
// Found benchmarks:
//   SimpleComparisonTest_DynamicCodeCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_DynamicCodeCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_DynamicCodeCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10

// **************************
// Benchmark: SimpleComparisonTest_DynamicCodeCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_DynamicCodeCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 31236 ns, 70 ticks, 31235.9996 ns/op, 32014.3 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 215974.6 ns, 484 ticks, 215.9746 ns/op, 4630173.6 op/s
// Pre-Warmup: 1000000 op, 220.3 ms, 220258419.9 ns, 493600 ticks, 220.2584 ns/op, 4540121.6 op/s
// Pre-Warmup: 5000000 op, 1076.4 ms, 1076421996.6 ns, 2412266 ticks, 215.2844 ns/op, 4645018.4 op/s
// Warmup (idle): 5000000 op, 14.2 ms, 14182036.3 ns, 31782 ticks, 2.8364 ns/op, 352558681 op/s
// Warmup (idle): 5000000 op, 14.5 ms, 14509121.8 ns, 32515 ticks, 2.9018 ns/op, 344610795 op/s
// Warmup (idle): 5000000 op, 14.8 ms, 14814342.1 ns, 33199 ticks, 2.9629 ns/op, 337510768.4 op/s
// IterationCount = 5000000
// Target (idle): 5000000 op, 14.3 ms, 14273513.1 ns, 31987 ticks, 2.8547 ns/op, 350299184 op/s
// Target (idle): 5000000 op, 14.4 ms, 14381946.7 ns, 32230 ticks, 2.8764 ns/op, 347658082.5 op/s
// Target (idle): 5000000 op, 14.2 ms, 14235137.5 ns, 31901 ticks, 2.847 ns/op, 351243534.7 op/s
// Target (idle): 5000000 op, 14.2 ms, 14161063.5 ns, 31735 ticks, 2.8322 ns/op, 353080825.6 op/s
// Target (idle): 5000000 op, 14.3 ms, 14324383.2 ns, 32101 ticks, 2.8649 ns/op, 349055169.6 op/s
// Warmup 1: 5000000 op, 1004.1 ms, 1004055325.2 ns, 2250092 ticks, 200.8111 ns/op, 4979805.3 op/s
// Warmup 2: 5000000 op, 1002.3 ms, 1002284244 ns, 2246123 ticks, 200.4568 ns/op, 4988604.8 op/s
// Warmup 3: 5000000 op, 1055.7 ms, 1055682631.5 ns, 2365789 ticks, 211.1365 ns/op, 4736271.9 op/s
// Warmup 4: 5000000 op, 1003.8 ms, 1003806775.9 ns, 2249535 ticks, 200.7614 ns/op, 4981038.3 op/s
// Warmup 5: 5000000 op, 1138.2 ms, 1138201449 ns, 2550714 ticks, 227.6403 ns/op, 4392895.5 op/s
Target 1: 5000000 op, 1049.2 ms, 1049150737.8 ns, 2351151 ticks, 209.8301 ns/op, 4765759.4 op/s
Target 2: 5000000 op, 1017.8 ms, 1017804073.5 ns, 2280903 ticks, 203.5608 ns/op, 4912536.8 op/s
Target 3: 5000000 op, 1060 ms, 1060011494.8 ns, 2375490 ticks, 212.0023 ns/op, 4716930 op/s
Target 4: 5000000 op, 1035.2 ms, 1035170843.1 ns, 2319822 ticks, 207.0342 ns/op, 4830120.6 op/s
Target 5: 5000000 op, 1007.9 ms, 1007892890.9 ns, 2258692 ticks, 201.5786 ns/op, 4960844.6 op/s
Target 6: 5000000 op, 1035.2 ms, 1035159241.1 ns, 2319796 ticks, 207.0318 ns/op, 4830174.7 op/s
Target 7: 5000000 op, 1158.3 ms, 1158299583.6 ns, 2595754 ticks, 231.6599 ns/op, 4316672.5 op/s
Target 8: 5000000 op, 1111.6 ms, 1111569189.5 ns, 2491031 ticks, 222.3138 ns/op, 4498145.5 op/s
Target 9: 5000000 op, 1083.9 ms, 1083939163 ns, 2429112 ticks, 216.7878 ns/op, 4612805 op/s
Target 10: 5000000 op, 1087.4 ms, 1087392079.6 ns, 2436850 ticks, 217.4784 ns/op, 4598157.5 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 45515.3 ns, 102 ticks, 45515.3137 ns/op, 21970.6 op/s
// Pre-Warmup: 1000 op, 0.4 ms, 399820.8 ns, 896 ticks, 399.8208 ns/op, 2501120.5 op/s
// Pre-Warmup: 1000000 op, 252.5 ms, 252542164.1 ns, 565948 ticks, 252.5422 ns/op, 3959734.8 op/s
// Pre-Warmup: 4000000 op, 878.7 ms, 878718199.5 ns, 1969211 ticks, 219.6795 ns/op, 4552085.1 op/s
// Pre-Warmup: 8000000 op, 1761.8 ms, 1761778203 ns, 3948152 ticks, 220.2223 ns/op, 4540866.7 op/s
// Warmup (idle): 8000000 op, 24.4 ms, 24403794 ns, 54689 ticks, 3.0505 ns/op, 327817879.3 op/s
// Warmup (idle): 8000000 op, 24 ms, 23974075.9 ns, 53726 ticks, 2.9968 ns/op, 333693779.5 op/s
// Warmup (idle): 8000000 op, 25 ms, 24965149.5 ns, 55947 ticks, 3.1206 ns/op, 320446708.5 op/s
// IterationCount = 8000000
// Target (idle): 8000000 op, 24.6 ms, 24569791 ns, 55061 ticks, 3.0712 ns/op, 325603094.7 op/s
// Target (idle): 8000000 op, 23.5 ms, 23505089.7 ns, 52675 ticks, 2.9381 ns/op, 340351817.8 op/s
// Target (idle): 8000000 op, 22.6 ms, 22563547.4 ns, 50565 ticks, 2.8204 ns/op, 354554177.8 op/s
// Target (idle): 8000000 op, 22.7 ms, 22706340.6 ns, 50885 ticks, 2.8383 ns/op, 352324496.4 op/s
// Target (idle): 8000000 op, 23.4 ms, 23426553.5 ns, 52499 ticks, 2.9283 ns/op, 341492828.4 op/s
// Warmup 1: 8000000 op, 1710.1 ms, 1710115644.6 ns, 3832376 ticks, 213.7645 ns/op, 4678046.2 op/s
// Warmup 2: 8000000 op, 1593.3 ms, 1593326027.1 ns, 3570650 ticks, 199.1658 ns/op, 5020943.5 op/s
// Warmup 3: 8000000 op, 1611.5 ms, 1611452277.6 ns, 3611271 ticks, 201.4315 ns/op, 4964466 op/s
// Warmup 4: 8000000 op, 1586.7 ms, 1586652678.9 ns, 3555695 ticks, 198.3316 ns/op, 5042061.3 op/s
// Warmup 5: 8000000 op, 1750 ms, 1750012494.4 ns, 3921785 ticks, 218.7516 ns/op, 4571395.9 op/s
Target 1: 8000000 op, 1597.1 ms, 1597132803 ns, 3579181 ticks, 199.6416 ns/op, 5008976.1 op/s
Target 2: 8000000 op, 1630.6 ms, 1630567816.9 ns, 3654109 ticks, 203.821 ns/op, 4906266.3 op/s
Target 3: 8000000 op, 1603.9 ms, 1603875316.6 ns, 3594291 ticks, 200.4844 ns/op, 4987918.9 op/s
Target 4: 8000000 op, 1677.5 ms, 1677531588.5 ns, 3759355 ticks, 209.6914 ns/op, 4768911.7 op/s
Target 5: 8000000 op, 1718.6 ms, 1718595772.3 ns, 3851380 ticks, 214.8245 ns/op, 4654963.2 op/s
Target 6: 8000000 op, 1764 ms, 1764045490.3 ns, 3953233 ticks, 220.5057 ns/op, 4535030.4 op/s
Target 7: 8000000 op, 1715.2 ms, 1715167398.2 ns, 3843697 ticks, 214.3959 ns/op, 4664267.8 op/s
Target 8: 8000000 op, 1767.3 ms, 1767336872.2 ns, 3960609 ticks, 220.9171 ns/op, 4526584.7 op/s
Target 9: 8000000 op, 1727.1 ms, 1727137033.2 ns, 3870521 ticks, 215.8921 ns/op, 4631942.8 op/s
Target 10: 8000000 op, 1760.7 ms, 1760659954.2 ns, 3945646 ticks, 220.0825 ns/op, 4543750.8 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 22757.7 ns, 51 ticks, 22757.6568 ns/op, 43941.3 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 215974.6 ns, 484 ticks, 215.9746 ns/op, 4630173.6 op/s
// Pre-Warmup: 1000000 op, 213.7 ms, 213729649.7 ns, 478969 ticks, 213.7296 ns/op, 4678808 op/s
// Pre-Warmup: 5000000 op, 1094.6 ms, 1094645971.2 ns, 2453106 ticks, 218.9292 ns/op, 4567686.8 op/s
// Warmup (idle): 5000000 op, 14.1 ms, 14139644.6 ns, 31687 ticks, 2.8279 ns/op, 353615678.4 op/s
// Warmup (idle): 5000000 op, 14.1 ms, 14140537 ns, 31689 ticks, 2.8281 ns/op, 353593360.5 op/s
// Warmup (idle): 5000000 op, 14.3 ms, 14334646.4 ns, 32124 ticks, 2.8669 ns/op, 348805254.6 op/s
// IterationCount = 5000000
// Target (idle): 5000000 op, 14.6 ms, 14610415.7 ns, 32742 ticks, 2.9221 ns/op, 342221611.4 op/s
// Target (idle): 5000000 op, 14.5 ms, 14476993.3 ns, 32443 ticks, 2.8954 ns/op, 345375581.8 op/s
// Target (idle): 5000000 op, 14.2 ms, 14206578.8 ns, 31837 ticks, 2.8413 ns/op, 351949618.4 op/s
// Target (idle): 5000000 op, 14.5 ms, 14511352.9 ns, 32520 ticks, 2.9023 ns/op, 344557810.6 op/s
// Target (idle): 5000000 op, 14.4 ms, 14394887.3 ns, 32259 ticks, 2.879 ns/op, 347345547 op/s
// Warmup 1: 5000000 op, 1003.8 ms, 1003759921.9 ns, 2249430 ticks, 200.752 ns/op, 4981270.8 op/s
// Warmup 2: 5000000 op, 998.4 ms, 998371265.7 ns, 2237354 ticks, 199.6743 ns/op, 5008157 op/s
// Warmup 3: 5000000 op, 999.7 ms, 999704150.5 ns, 2240341 ticks, 199.9408 ns/op, 5001479.7 op/s
// Warmup 4: 5000000 op, 994.6 ms, 994550656.8 ns, 2228792 ticks, 198.9101 ns/op, 5027396 op/s
// Warmup 5: 5000000 op, 1010.6 ms, 1010565800 ns, 2264682 ticks, 202.1132 ns/op, 4947723.3 op/s
Target 1: 5000000 op, 1084.8 ms, 1084825372.9 ns, 2431098 ticks, 216.9651 ns/op, 4609036.7 op/s
Target 2: 5000000 op, 1092.8 ms, 1092789214.1 ns, 2448945 ticks, 218.5578 ns/op, 4575447.8 op/s
Target 3: 5000000 op, 1078.2 ms, 1078165411.6 ns, 2416173 ticks, 215.6331 ns/op, 4637507.3 op/s
Target 4: 5000000 op, 1106 ms, 1106019444.9 ns, 2478594 ticks, 221.2039 ns/op, 4520716.2 op/s
Target 5: 5000000 op, 1141.9 ms, 1141881942.2 ns, 2558962 ticks, 228.3764 ns/op, 4378736.4 op/s
Target 6: 5000000 op, 1100.3 ms, 1100334492.9 ns, 2465854 ticks, 220.0669 ns/op, 4544072.8 op/s
Target 7: 5000000 op, 1084.2 ms, 1084191282.1 ns, 2429677 ticks, 216.8383 ns/op, 4611732.3 op/s
Target 8: 5000000 op, 1082.8 ms, 1082825376.5 ns, 2426616 ticks, 216.5651 ns/op, 4617549.7 op/s
Target 9: 5000000 op, 1015.9 ms, 1015868780.2 ns, 2276566 ticks, 203.1738 ns/op, 4921895.5 op/s
Target 10: 5000000 op, 1028.1 ms, 1028113292.1 ns, 2304006 ticks, 205.6227 ns/op, 4863277.3 op/s
// Benchmark finished

AverageTime (ns/op): Avr=213.751234565167 +- 2.93659304277527
OperationsPerSecond: Avr=4685024.37748256 +- 64555.0741066254

// **************************
// Benchmark: SimpleComparisonTest_ManualCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 5801 ns, 13 ticks, 5800.9714 ns/op, 172384.9 op/s
// Pre-Warmup: 1000 op, 0.3 ms, 279339.1 ns, 626 ticks, 279.3391 ns/op, 3579878.6 op/s
// Pre-Warmup: 1000000 op, 168.7 ms, 168725714 ns, 378115 ticks, 168.7257 ns/op, 5926778.9 op/s
// Pre-Warmup: 6000000 op, 1007.6 ms, 1007587224.3 ns, 2258007 ticks, 167.9312 ns/op, 5954819.4 op/s
// Warmup (idle): 6000000 op, 18 ms, 17975871.5 ns, 40284 ticks, 2.996 ns/op, 333780756.6 op/s
// Warmup (idle): 6000000 op, 18.3 ms, 18290908.9 ns, 40990 ticks, 3.0485 ns/op, 328031812.6 op/s
// Warmup (idle): 6000000 op, 17.8 ms, 17835755.8 ns, 39970 ticks, 2.9726 ns/op, 336402902.2 op/s
// IterationCount = 6060606
// Target (idle): 6060606 op, 17.5 ms, 17497514.5 ns, 39212 ticks, 2.8871 ns/op, 346369537.1 op/s
// Target (idle): 6060606 op, 17.4 ms, 17422994.3 ns, 39045 ticks, 2.8748 ns/op, 347850999.8 op/s
// Target (idle): 6060606 op, 17.7 ms, 17707241.9 ns, 39682 ticks, 2.9217 ns/op, 342267080.5 op/s
// Target (idle): 6060606 op, 18.4 ms, 18439056.8 ns, 41322 ticks, 3.0424 ns/op, 328683081.4 op/s
// Target (idle): 6060606 op, 18.7 ms, 18688944.8 ns, 41882 ticks, 3.0837 ns/op, 324288293 op/s
// Warmup 1: 6060606 op, 972.1 ms, 972092419.3 ns, 2178463 ticks, 160.3953 ns/op, 6234598.6 op/s
// Warmup 2: 6060606 op, 988.1 ms, 988105777.6 ns, 2214349 ticks, 163.0375 ns/op, 6133559.9 op/s
// Warmup 3: 6060606 op, 981.9 ms, 981938898.8 ns, 2200529 ticks, 162.0199 ns/op, 6172080.6 op/s
// Warmup 4: 6060606 op, 965 ms, 964960794.4 ns, 2162481 ticks, 159.2185 ns/op, 6280675.9 op/s
// Warmup 5: 6060606 op, 942.5 ms, 942529776.8 ns, 2112213 ticks, 155.5174 ns/op, 6430148 op/s
Target 1: 6060606 op, 912.9 ms, 912897076.5 ns, 2045806 ticks, 150.628 ns/op, 6638871.1 op/s
Target 2: 6060606 op, 903.8 ms, 903845330 ns, 2025521 ticks, 149.1345 ns/op, 6705357.4 op/s
Target 3: 6060606 op, 947.1 ms, 947105404.5 ns, 2122467 ticks, 156.2724 ns/op, 6399082.9 op/s
Target 4: 6060606 op, 1069.8 ms, 1069804426.9 ns, 2397436 ticks, 176.5177 ns/op, 5665153.2 op/s
Target 5: 6060606 op, 987.3 ms, 987349420.2 ns, 2212654 ticks, 162.9127 ns/op, 6138258.5 op/s
Target 6: 6060606 op, 1014.2 ms, 1014160617.3 ns, 2272738 ticks, 167.3365 ns/op, 5975982.4 op/s
Target 7: 6060606 op, 960.2 ms, 960171869.4 ns, 2151749 ticks, 158.4284 ns/op, 6312001.2 op/s
Target 8: 6060606 op, 967.1 ms, 967068331.9 ns, 2167204 ticks, 159.5663 ns/op, 6266988.4 op/s
Target 9: 6060606 op, 973 ms, 973034407.8 ns, 2180574 ticks, 160.5507 ns/op, 6228562.9 op/s
Target 10: 6060606 op, 916.8 ms, 916802022.7 ns, 2054557 ticks, 151.2723 ns/op, 6610594.1 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 10709.5 ns, 24 ticks, 10709.4856 ns/op, 93375.2 op/s
// Pre-Warmup: 1000 op, 0.3 ms, 311467.5 ns, 698 ticks, 311.4675 ns/op, 3210607.4 op/s
// Pre-Warmup: 1000000 op, 163.5 ms, 163541430.5 ns, 366497 ticks, 163.5414 ns/op, 6114658.5 op/s
// Pre-Warmup: 7000000 op, 1165.2 ms, 1165174627.1 ns, 2611161 ticks, 166.4535 ns/op, 6007683.2 op/s
// Warmup (idle): 7000000 op, 19.6 ms, 19601928.4 ns, 43928 ticks, 2.8003 ns/op, 357107721.7 op/s
// Warmup (idle): 7000000 op, 20.3 ms, 20275287.3 ns, 45437 ticks, 2.8965 ns/op, 345247881.7 op/s
// Warmup (idle): 7000000 op, 21.7 ms, 21715266.9 ns, 48664 ticks, 3.1022 ns/op, 322353855 op/s
// IterationCount = 7000000
// Target (idle): 7000000 op, 21.8 ms, 21801389 ns, 48857 ticks, 3.1145 ns/op, 321080459.3 op/s
// Target (idle): 7000000 op, 21 ms, 21015580.5 ns, 47096 ticks, 3.0022 ns/op, 333086206.9 op/s
// Target (idle): 7000000 op, 20.9 ms, 20906254.5 ns, 46851 ticks, 2.9866 ns/op, 334828029.3 op/s
// Target (idle): 7000000 op, 20.3 ms, 20252975.9 ns, 45387 ticks, 2.8933 ns/op, 345628219.5 op/s
// Target (idle): 7000000 op, 20.1 ms, 20127585.7 ns, 45106 ticks, 2.8754 ns/op, 347781403.8 op/s
// Warmup 1: 7000000 op, 1135.1 ms, 1135093020.8 ns, 2543748 ticks, 162.1561 ns/op, 6166895.5 op/s
// Warmup 2: 7000000 op, 1044.8 ms, 1044753601.5 ns, 2341297 ticks, 149.2505 ns/op, 6700144.4 op/s
// Warmup 3: 7000000 op, 1113.7 ms, 1113675834.6 ns, 2495752 ticks, 159.0965 ns/op, 6285491.5 op/s
// Warmup 4: 7000000 op, 1051.7 ms, 1051698256.7 ns, 2356860 ticks, 150.2426 ns/op, 6655901.5 op/s
// Warmup 5: 7000000 op, 1046.3 ms, 1046257838 ns, 2344668 ticks, 149.4654 ns/op, 6690511.4 op/s
Target 1: 7000000 op, 1056.1 ms, 1056127967.6 ns, 2366787 ticks, 150.8754 ns/op, 6627984.7 op/s
Target 2: 7000000 op, 1149.4 ms, 1149445516.4 ns, 2575912 ticks, 164.2065 ns/op, 6089892.8 op/s
Target 3: 7000000 op, 1114.5 ms, 1114463874.2 ns, 2497518 ticks, 159.2091 ns/op, 6281047 op/s
Target 4: 7000000 op, 1159.9 ms, 1159922963.1 ns, 2599392 ticks, 165.7033 ns/op, 6034883.5 op/s
Target 5: 7000000 op, 1180.6 ms, 1180630199.7 ns, 2645797 ticks, 168.6615 ns/op, 5929036.9 op/s
Target 6: 7000000 op, 1123.1 ms, 1123068945.9 ns, 2516802 ticks, 160.4384 ns/op, 6232921 op/s
Target 7: 7000000 op, 1161.6 ms, 1161642281.8 ns, 2603245 ticks, 165.9489 ns/op, 6025951.5 op/s
Target 8: 7000000 op, 1099.9 ms, 1099862383.1 ns, 2464796 ticks, 157.1232 ns/op, 6364432.6 op/s
Target 9: 7000000 op, 1045.8 ms, 1045755830.9 ns, 2343543 ticks, 149.3937 ns/op, 6693723.1 op/s
Target 10: 7000000 op, 1049.5 ms, 1049500134.8 ns, 2351934 ticks, 149.9286 ns/op, 6669841.9 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 7139.7 ns, 16 ticks, 7139.657 ns/op, 140062.8 op/s
// Pre-Warmup: 1000 op, 0.3 ms, 290048.6 ns, 650 ticks, 290.0486 ns/op, 3447698.5 op/s
// Pre-Warmup: 1000000 op, 171.1 ms, 171111251.9 ns, 383461 ticks, 171.1113 ns/op, 5844151 op/s
// Pre-Warmup: 6000000 op, 988.8 ms, 988800555.5 ns, 2215906 ticks, 164.8001 ns/op, 6067957.8 op/s
// Pre-Warmup: 12000000 op, 1905.1 ms, 1905140731.6 ns, 4269428 ticks, 158.7617 ns/op, 6298747.3 op/s
// Warmup (idle): 12000000 op, 34.1 ms, 34132469.2 ns, 76491 ticks, 2.8444 ns/op, 351571400.6 op/s
// Warmup (idle): 12000000 op, 34.1 ms, 34109265.3 ns, 76439 ticks, 2.8424 ns/op, 351810567.9 op/s
// Warmup (idle): 12000000 op, 36 ms, 35991011.2 ns, 80656 ticks, 2.9993 ns/op, 333416584 op/s
// IterationCount = 12000000
// Target (idle): 12000000 op, 36.5 ms, 36512206.1 ns, 81824 ticks, 3.0427 ns/op, 328657215.5 op/s
// Target (idle): 12000000 op, 37.2 ms, 37181102.8 ns, 83323 ticks, 3.0984 ns/op, 322744596.3 op/s
// Target (idle): 12000000 op, 36.4 ms, 36363165.8 ns, 81490 ticks, 3.0303 ns/op, 330004270.5 op/s
// Target (idle): 12000000 op, 36.2 ms, 36196722.5 ns, 81117 ticks, 3.0164 ns/op, 331521727.9 op/s
// Target (idle): 12000000 op, 38.4 ms, 38424741.8 ns, 86110 ticks, 3.2021 ns/op, 312298780.6 op/s
// Warmup 1: 12000000 op, 1806.9 ms, 1806927609.2 ns, 4049332 ticks, 150.5773 ns/op, 6641107.2 op/s
// Warmup 2: 12000000 op, 1824.3 ms, 1824280099.5 ns, 4088219 ticks, 152.0233 ns/op, 6577937.2 op/s
// Warmup 3: 12000000 op, 1960 ms, 1960018366.8 ns, 4392409 ticks, 163.3349 ns/op, 6122391.6 op/s
// Warmup 4: 12000000 op, 1965 ms, 1964968826.5 ns, 4403503 ticks, 163.7474 ns/op, 6106967.1 op/s
// Warmup 5: 12000000 op, 1949 ms, 1949012139.2 ns, 4367744 ticks, 162.4177 ns/op, 6156965.2 op/s
Target 1: 12000000 op, 1901.4 ms, 1901374116.2 ns, 4260987 ticks, 158.4478 ns/op, 6311225.1 op/s
Target 2: 12000000 op, 1811.8 ms, 1811796409.1 ns, 4060243 ticks, 150.983 ns/op, 6623260.7 op/s
Target 3: 12000000 op, 1808.9 ms, 1808916003.7 ns, 4053788 ticks, 150.743 ns/op, 6633807.2 op/s
Target 4: 12000000 op, 1947 ms, 1947005449.3 ns, 4363247 ticks, 162.2505 ns/op, 6163310.9 op/s
Target 5: 12000000 op, 1944.9 ms, 1944872923 ns, 4358468 ticks, 162.0727 ns/op, 6170068.9 op/s
Target 6: 12000000 op, 1944.9 ms, 1944869353.2 ns, 4358460 ticks, 162.0724 ns/op, 6170080.3 op/s
Target 7: 12000000 op, 1939.3 ms, 1939292834.8 ns, 4345963 ticks, 161.6077 ns/op, 6187822.6 op/s
Target 8: 12000000 op, 1995.5 ms, 1995518080.3 ns, 4471964 ticks, 166.2932 ns/op, 6013476 op/s
Target 9: 12000000 op, 1992 ms, 1992004030.3 ns, 4464089 ticks, 166.0003 ns/op, 6024084.2 op/s
Target 10: 12000000 op, 1974.2 ms, 1974188354.9 ns, 4424164 ticks, 164.5157 ns/op, 6078447.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=159.636482795711 +- 2.46731675998694
OperationsPerSecond: Avr=6275538.34644507 +- 97024.662795653

// **************************
// Benchmark: SimpleComparisonTest_ReflectionCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 43730.4 ns, 98 ticks, 43730.3994 ns/op, 22867.4 op/s
// Pre-Warmup: 1000 op, 6.1 ms, 6062461.3 ns, 13586 ticks, 6062.4613 ns/op, 164949.5 op/s
// Pre-Warmup: 165000 op, 1139.8 ms, 1139848478.6 ns, 2554405 ticks, 6908.1726 ns/op, 144756.1 op/s
// Warmup (idle): 165000 op, 0.5 ms, 470771.1 ns, 1055 ticks, 2.8532 ns/op, 350488777.3 op/s
// Warmup (idle): 165000 op, 0.5 ms, 488620.3 ns, 1095 ticks, 2.9613 ns/op, 337685534.2 op/s
// Warmup (idle): 165000 op, 0.5 ms, 488620.3 ns, 1095 ticks, 2.9613 ns/op, 337685534.2 op/s
// IterationCount = 165000
// Target (idle): 165000 op, 0.5 ms, 493528.8 ns, 1106 ticks, 2.9911 ns/op, 334326998.2 op/s
// Target (idle): 165000 op, 0.5 ms, 494867.5 ns, 1109 ticks, 2.9992 ns/op, 333422596.9 op/s
// Target (idle): 165000 op, 0.5 ms, 494421.3 ns, 1108 ticks, 2.9965 ns/op, 333723519.9 op/s
// Target (idle): 165000 op, 0.5 ms, 514501.5 ns, 1153 ticks, 3.1182 ns/op, 320698751.1 op/s
// Target (idle): 165000 op, 0.5 ms, 492636.3 ns, 1104 ticks, 2.9857 ns/op, 334932663 op/s
// Warmup 1: 165000 op, 1113.5 ms, 1113493773.3 ns, 2495344 ticks, 6748.4471 ns/op, 148182.2 op/s
// Warmup 2: 165000 op, 1132.7 ms, 1132723100.9 ns, 2538437 ticks, 6864.9885 ns/op, 145666.7 op/s
// Warmup 3: 165000 op, 1009.6 ms, 1009624703.9 ns, 2262573 ticks, 6118.9376 ns/op, 163427.1 op/s
// Warmup 4: 165000 op, 995 ms, 995001347.6 ns, 2229802 ticks, 6030.3112 ns/op, 165828.9 op/s
// Warmup 5: 165000 op, 998.7 ms, 998749221.3 ns, 2238201 ticks, 6053.0256 ns/op, 165206.6 op/s
Target 1: 165000 op, 1016.5 ms, 1016480559.6 ns, 2277937 ticks, 6160.4882 ns/op, 162324.8 op/s
Target 2: 165000 op, 1032.3 ms, 1032295792.4 ns, 2313379 ticks, 6256.3381 ns/op, 159837.9 op/s
Target 3: 165000 op, 1128.2 ms, 1128196112.1 ns, 2528292 ticks, 6837.5522 ns/op, 146251.2 op/s
Target 4: 165000 op, 1109.8 ms, 1109834252.9 ns, 2487143 ticks, 6726.2682 ns/op, 148670.8 op/s
Target 5: 165000 op, 998.8 ms, 998815709.4 ns, 2238350 ticks, 6053.4285 ns/op, 165195.6 op/s
Target 6: 165000 op, 1009.2 ms, 1009175798 ns, 2261567 ticks, 6116.217 ns/op, 163499.8 op/s
Target 7: 165000 op, 1012.4 ms, 1012396675.8 ns, 2268785 ticks, 6135.7374 ns/op, 162979.6 op/s
Target 8: 165000 op, 1016.1 ms, 1016142764.6 ns, 2277180 ticks, 6158.441 ns/op, 162378.8 op/s
Target 9: 165000 op, 1075.4 ms, 1075438062.6 ns, 2410061 ticks, 6517.8064 ns/op, 153425.9 op/s
Target 10: 165000 op, 1121 ms, 1120960069.7 ns, 2512076 ticks, 6793.6974 ns/op, 147195.3 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 29451.1 ns, 66 ticks, 29451.0853 ns/op, 33954.6 op/s
// Pre-Warmup: 1000 op, 7.2 ms, 7190080.9 ns, 16113 ticks, 7190.0809 ns/op, 139080.5 op/s
// Pre-Warmup: 140000 op, 970.4 ms, 970402105.5 ns, 2174675 ticks, 6931.4436 ns/op, 144270.1 op/s
// Pre-Warmup: 280000 op, 1945.1 ms, 1945075510.8 ns, 4358922 ticks, 6946.6983 ns/op, 143953.3 op/s
// Warmup (idle): 280000 op, 0.8 ms, 787593.4 ns, 1765 ticks, 2.8128 ns/op, 355513382.4 op/s
// Warmup (idle): 280000 op, 0.8 ms, 820614.3 ns, 1839 ticks, 2.9308 ns/op, 341207786.8 op/s
// Warmup (idle): 280000 op, 0.8 ms, 821060.6 ns, 1840 ticks, 2.9324 ns/op, 341022347.8 op/s
// IterationCount = 280000
// Target (idle): 280000 op, 1 ms, 980810.4 ns, 2198 ticks, 3.5029 ns/op, 285478216.6 op/s
// Target (idle): 280000 op, 1 ms, 982595.3 ns, 2202 ticks, 3.5093 ns/op, 284959636.7 op/s
// Target (idle): 280000 op, 0.8 ms, 837124.8 ns, 1876 ticks, 2.9897 ns/op, 334478209 op/s
// Target (idle): 280000 op, 0.9 ms, 887994.8 ns, 1990 ticks, 3.1714 ns/op, 315317145.7 op/s
// Target (idle): 280000 op, 0.8 ms, 845156.9 ns, 1894 ticks, 3.0184 ns/op, 331299429.8 op/s
// Warmup 1: 280000 op, 1818.7 ms, 1818735709.5 ns, 4075794 ticks, 6495.4847 ns/op, 153953.1 op/s
// Warmup 2: 280000 op, 1812.5 ms, 1812495203 ns, 4061809 ticks, 6473.1972 ns/op, 154483.2 op/s
// Warmup 3: 280000 op, 1954.3 ms, 1954312442.1 ns, 4379622 ticks, 6979.6873 ns/op, 143272.9 op/s
// Warmup 4: 280000 op, 1908.7 ms, 1908654781.5 ns, 4277303 ticks, 6816.6242 ns/op, 146700.2 op/s
// Warmup 5: 280000 op, 1768.9 ms, 1768899118.4 ns, 3964110 ticks, 6317.4969 ns/op, 158290.5 op/s
Target 1: 280000 op, 1716.4 ms, 1716360613.4 ns, 3846371 ticks, 6129.8593 ns/op, 163135.9 op/s
Target 2: 280000 op, 1737.8 ms, 1737796541.2 ns, 3894409 ticks, 6206.4162 ns/op, 161123.6 op/s
Target 3: 280000 op, 1885.1 ms, 1885087666.1 ns, 4224489 ticks, 6732.456 ns/op, 148534.2 op/s
Target 4: 280000 op, 1905.9 ms, 1905913153.2 ns, 4271159 ticks, 6806.8327 ns/op, 146911.2 op/s
Target 5: 280000 op, 1906.8 ms, 1906769465.8 ns, 4273078 ticks, 6809.8909 ns/op, 146845.2 op/s
Target 6: 280000 op, 1937.4 ms, 1937376283.1 ns, 4341668 ticks, 6919.201 ns/op, 144525.4 op/s
Target 7: 280000 op, 1935.8 ms, 1935762274.4 ns, 4338051 ticks, 6913.4367 ns/op, 144645.9 op/s
Target 8: 280000 op, 1884.2 ms, 1884233584.6 ns, 4222575 ticks, 6729.4057 ns/op, 148601.5 op/s
Target 9: 280000 op, 1908.4 ms, 1908350007.4 ns, 4276620 ticks, 6815.5357 ns/op, 146723.6 op/s
Target 10: 280000 op, 1951.2 ms, 1951228556.5 ns, 4372711 ticks, 6968.6734 ns/op, 143499.3 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 34805.8 ns, 78 ticks, 34805.8281 ns/op, 28730.8 op/s
// Pre-Warmup: 1000 op, 11.7 ms, 11709483.8 ns, 26241 ticks, 11709.4838 ns/op, 85400.9 op/s
// Pre-Warmup: 86000 op, 594.5 ms, 594465248.6 ns, 1332199 ticks, 6912.3866 ns/op, 144667.8 op/s
// Pre-Warmup: 172000 op, 1193.3 ms, 1193252667.1 ns, 2674084 ticks, 6937.5155 ns/op, 144143.8 op/s
// Warmup (idle): 172000 op, 0.6 ms, 555554.6 ns, 1245 ticks, 3.23 ns/op, 309600552.6 op/s
// Warmup (idle): 172000 op, 0.5 ms, 508254.3 ns, 1139 ticks, 2.955 ns/op, 338413246.7 op/s
// Warmup (idle): 172000 op, 0.5 ms, 508254.3 ns, 1139 ticks, 2.955 ns/op, 338413246.7 op/s
// IterationCount = 172000
// Target (idle): 172000 op, 0.5 ms, 513609.1 ns, 1151 ticks, 2.9861 ns/op, 334885046 op/s
// Target (idle): 172000 op, 0.5 ms, 514947.8 ns, 1154 ticks, 2.9939 ns/op, 334014461 op/s
// Target (idle): 172000 op, 0.5 ms, 511824.2 ns, 1147 ticks, 2.9757 ns/op, 336052910.2 op/s
// Target (idle): 172000 op, 0.5 ms, 512716.6 ns, 1149 ticks, 2.9809 ns/op, 335467961.7 op/s
// Target (idle): 172000 op, 0.5 ms, 512716.6 ns, 1149 ticks, 2.9809 ns/op, 335467961.7 op/s
// Warmup 1: 172000 op, 1307.3 ms, 1307264958 ns, 2929586 ticks, 7600.3777 ns/op, 131572.4 op/s
// Warmup 2: 172000 op, 1124.7 ms, 1124674476.3 ns, 2520400 ticks, 6538.8051 ns/op, 152933.1 op/s
// Warmup 3: 172000 op, 1054.3 ms, 1054311817.4 ns, 2362717 ticks, 6129.7199 ns/op, 163139.6 op/s
// Warmup 4: 172000 op, 1049 ms, 1049038734.4 ns, 2350900 ticks, 6099.0624 ns/op, 163959.6 op/s
// Warmup 5: 172000 op, 1073.9 ms, 1073916869.4 ns, 2406652 ticks, 6243.7027 ns/op, 160161.4 op/s
Target 1: 172000 op, 1043.4 ms, 1043401529 ns, 2338267 ticks, 6066.288 ns/op, 164845.5 op/s
Target 2: 172000 op, 1273.4 ms, 1273410043 ns, 2853717 ticks, 7403.5468 ns/op, 135070.4 op/s
Target 3: 172000 op, 1162.8 ms, 1162827464.8 ns, 2605901 ticks, 6760.6248 ns/op, 147915.3 op/s
Target 4: 172000 op, 1061.6 ms, 1061609439.3 ns, 2379071 ticks, 6172.1479 ns/op, 162018.2 op/s
Target 5: 172000 op, 1049.8 ms, 1049754931.3 ns, 2352505 ticks, 6103.2263 ns/op, 163847.8 op/s
Target 6: 172000 op, 1063.6 ms, 1063572845 ns, 2383471 ticks, 6183.5631 ns/op, 161719.1 op/s
Target 7: 172000 op, 1043.5 ms, 1043546999.5 ns, 2338593 ticks, 6067.1337 ns/op, 164822.5 op/s
Target 8: 172000 op, 1145.1 ms, 1145134502.2 ns, 2566251 ticks, 6657.7587 ns/op, 150200.7 op/s
Target 9: 172000 op, 1220.3 ms, 1220319999.4 ns, 2734742 ticks, 7094.8837 ns/op, 140946.6 op/s
Target 10: 172000 op, 1144 ms, 1143954673.9 ns, 2563607 ticks, 6650.8993 ns/op, 150355.6 op/s
// Benchmark finished

AverageTime (ns/op): Avr=6531.59181478062 +- 136.260008901332
OperationsPerSecond: Avr=153601.564786595 +- 3175.96965204074

// **************************
// Benchmark: SimpleComparisonTest_DynamicCodeCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_DynamicCodeCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 45515.3 ns, 102 ticks, 45515.3137 ns/op, 21970.6 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 249888 ns, 560 ticks, 249.888 ns/op, 4001792.9 op/s
// Pre-Warmup: 1000000 op, 179.3 ms, 179279465.8 ns, 401766 ticks, 179.2795 ns/op, 5577883.6 op/s
// Pre-Warmup: 6000000 op, 1060.1 ms, 1060088692.4 ns, 2375663 ticks, 176.6814 ns/op, 5659903.8 op/s
// Warmup (idle): 6000000 op, 17.2 ms, 17248519 ns, 38654 ticks, 2.8748 ns/op, 347855952.8 op/s
// Warmup (idle): 6000000 op, 17.7 ms, 17671989.9 ns, 39603 ticks, 2.9453 ns/op, 339520339.4 op/s
// Warmup (idle): 6000000 op, 17.1 ms, 17076274.7 ns, 38268 ticks, 2.846 ns/op, 351364691.1 op/s
// IterationCount = 6000000
// Target (idle): 6000000 op, 17 ms, 17036114.2 ns, 38178 ticks, 2.8394 ns/op, 352192990.7 op/s
// Target (idle): 6000000 op, 17.3 ms, 17323485.4 ns, 38822 ticks, 2.8872 ns/op, 346350625.9 op/s
// Target (idle): 6000000 op, 17.6 ms, 17610856.6 ns, 39466 ticks, 2.9351 ns/op, 340698930.7 op/s
// Target (idle): 6000000 op, 17.7 ms, 17747402.5 ns, 39772 ticks, 2.9579 ns/op, 338077642.6 op/s
// Target (idle): 6000000 op, 18.7 ms, 18658155 ns, 41813 ticks, 3.1097 ns/op, 321575203.9 op/s
// Warmup 1: 6000000 op, 1052.1 ms, 1052055685.8 ns, 2357661 ticks, 175.3426 ns/op, 5703120.2 op/s
// Warmup 2: 6000000 op, 1006.9 ms, 1006941085.3 ns, 2256559 ticks, 167.8235 ns/op, 5958640.6 op/s
// Warmup 3: 6000000 op, 1001.2 ms, 1001213295.5 ns, 2243723 ticks, 166.8689 ns/op, 5992729 op/s
// Warmup 4: 6000000 op, 976 ms, 976018338.2 ns, 2187261 ticks, 162.6697 ns/op, 6147425.5 op/s
// Warmup 5: 6000000 op, 966.8 ms, 966827814.7 ns, 2166665 ticks, 161.138 ns/op, 6205862 op/s
Target 1: 6000000 op, 962.7 ms, 962744377.1 ns, 2157514 ticks, 160.4574 ns/op, 6232183.9 op/s
Target 2: 6000000 op, 1009.2 ms, 1009170889.5 ns, 2261556 ticks, 168.1951 ns/op, 5945474.7 op/s
Target 3: 6000000 op, 1049.5 ms, 1049546988.8 ns, 2352039 ticks, 174.9245 ns/op, 5716752.1 op/s
Target 4: 6000000 op, 1058.9 ms, 1058947685.9 ns, 2373106 ticks, 176.4913 ns/op, 5666002.3 op/s
Target 5: 6000000 op, 1045.8 ms, 1045768325.3 ns, 2343571 ticks, 174.2947 ns/op, 5737408.4 op/s
Target 6: 6000000 op, 1011.9 ms, 1011861647.7 ns, 2267586 ticks, 168.6436 ns/op, 5929664.4 op/s
Target 7: 6000000 op, 1005 ms, 1004950459.7 ns, 2252098 ticks, 167.4917 ns/op, 5970443.6 op/s
Target 8: 6000000 op, 985.7 ms, 985655090.3 ns, 2208857 ticks, 164.2758 ns/op, 6087322.1 op/s
Target 9: 6000000 op, 963.3 ms, 963332506.3 ns, 2158832 ticks, 160.5554 ns/op, 6228379 op/s
Target 10: 6000000 op, 970.3 ms, 970277607.7 ns, 2174396 ticks, 161.7129 ns/op, 6183797.2 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 27666.2 ns, 62 ticks, 27666.1711 ns/op, 36145.2 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 161534.7 ns, 362 ticks, 161.5347 ns/op, 6190618.8 op/s
// Pre-Warmup: 1000000 op, 185 ms, 184974681 ns, 414529 ticks, 184.9747 ns/op, 5406145.3 op/s
// Pre-Warmup: 6000000 op, 1074.3 ms, 1074307319.4 ns, 2407527 ticks, 179.0512 ns/op, 5584994.1 op/s
// Warmup (idle): 6000000 op, 17.8 ms, 17802734.8 ns, 39896 ticks, 2.9671 ns/op, 337026869.9 op/s
// Warmup (idle): 6000000 op, 17.3 ms, 17274846.5 ns, 38713 ticks, 2.8791 ns/op, 347325807.9 op/s
// Warmup (idle): 6000000 op, 18.1 ms, 18120449.6 ns, 40608 ticks, 3.0201 ns/op, 331117612.3 op/s
// IterationCount = 6000000
// Target (idle): 6000000 op, 17.9 ms, 17875916.3 ns, 40060 ticks, 2.9793 ns/op, 335647129.3 op/s
// Target (idle): 6000000 op, 19.2 ms, 19181134.9 ns, 42985 ticks, 3.1969 ns/op, 312807351.4 op/s
// Target (idle): 6000000 op, 17.4 ms, 17359629.9 ns, 38903 ticks, 2.8933 ns/op, 345629488.7 op/s
// Target (idle): 6000000 op, 17.2 ms, 17173998.8 ns, 38487 ticks, 2.8623 ns/op, 349365344.1 op/s
// Target (idle): 6000000 op, 16.9 ms, 16895105.9 ns, 37862 ticks, 2.8159 ns/op, 355132428.3 op/s
// Warmup 1: 6000000 op, 1055.8 ms, 1055784371.6 ns, 2366017 ticks, 175.9641 ns/op, 5682978.6 op/s
// Warmup 2: 6000000 op, 1069.1 ms, 1069069488.5 ns, 2395789 ticks, 178.1782 ns/op, 5612357.3 op/s
// Warmup 3: 6000000 op, 1054.3 ms, 1054293968.2 ns, 2362677 ticks, 175.7157 ns/op, 5691012.4 op/s
// Warmup 4: 6000000 op, 1062.9 ms, 1062933845.7 ns, 2382039 ticks, 177.1556 ns/op, 5644753.9 op/s
// Warmup 5: 6000000 op, 1043.1 ms, 1043104340.7 ns, 2337601 ticks, 173.8507 ns/op, 5752061.2 op/s
Target 1: 6000000 op, 1065.3 ms, 1065293502.4 ns, 2387327 ticks, 177.5489 ns/op, 5632250.6 op/s
Target 2: 6000000 op, 1053.2 ms, 1053237299 ns, 2360309 ticks, 175.5395 ns/op, 5696721.9 op/s
Target 3: 6000000 op, 1256.5 ms, 1256523861.6 ns, 2815875 ticks, 209.4206 ns/op, 4775078.4 op/s
Target 4: 6000000 op, 1040.5 ms, 1040536741.6 ns, 2331847 ticks, 173.4228 ns/op, 5766254.8 op/s
Target 5: 6000000 op, 1018.2 ms, 1018196308.4 ns, 2281782 ticks, 169.6994 ns/op, 5892773.3 op/s
Target 6: 6000000 op, 976.8 ms, 976755507.8 ns, 2188913 ticks, 162.7926 ns/op, 6142785.9 op/s
Target 7: 6000000 op, 975.9 ms, 975891163.1 ns, 2186976 ticks, 162.6485 ns/op, 6148226.6 op/s
Target 8: 6000000 op, 977 ms, 976984423.1 ns, 2189426 ticks, 162.8307 ns/op, 6141346.6 op/s
Target 9: 6000000 op, 980.8 ms, 980784059.3 ns, 2197941 ticks, 163.464 ns/op, 6117554.6 op/s
Target 10: 6000000 op, 1056.1 ms, 1056054786.2 ns, 2366623 ticks, 176.0091 ns/op, 5681523.4 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 26773.7 ns, 60 ticks, 26773.7139 ns/op, 37350.1 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 164212.1 ns, 368 ticks, 164.2121 ns/op, 6089684.8 op/s
// Pre-Warmup: 1000000 op, 181.8 ms, 181822968.6 ns, 407466 ticks, 181.823 ns/op, 5499855.2 op/s
// Pre-Warmup: 6000000 op, 1065.7 ms, 1065655393.7 ns, 2388138 ticks, 177.6092 ns/op, 5630337.9 op/s
// Warmup (idle): 6000000 op, 17.8 ms, 17751864.8 ns, 39782 ticks, 2.9586 ns/op, 337992660 op/s
// Warmup (idle): 6000000 op, 17.3 ms, 17295373 ns, 38759 ticks, 2.8826 ns/op, 346913594.3 op/s
// Warmup (idle): 6000000 op, 17.2 ms, 17223530.2 ns, 38598 ticks, 2.8706 ns/op, 348360640.4 op/s
// IterationCount = 6000000
// Target (idle): 6000000 op, 17.1 ms, 17105725.8 ns, 38334 ticks, 2.851 ns/op, 350759743.3 op/s
// Target (idle): 6000000 op, 17.6 ms, 17580066.8 ns, 39397 ticks, 2.93 ns/op, 341295631.6 op/s
// Target (idle): 6000000 op, 18.2 ms, 18178013.1 ns, 40737 ticks, 3.0297 ns/op, 330069077.3 op/s
// Target (idle): 6000000 op, 19.7 ms, 19673771.2 ns, 44089 ticks, 3.279 ns/op, 304974574.2 op/s
// Target (idle): 6000000 op, 17.3 ms, 17296265.4 ns, 38761 ticks, 2.8827 ns/op, 346895694.1 op/s
// Warmup 1: 6000000 op, 1065 ms, 1065018179.4 ns, 2386710 ticks, 177.503 ns/op, 5633706.7 op/s
// Warmup 2: 6000000 op, 1071.6 ms, 1071603174.3 ns, 2401467 ticks, 178.6005 ns/op, 5599087.6 op/s
// Warmup 3: 6000000 op, 1062.7 ms, 1062726795.7 ns, 2381575 ticks, 177.1211 ns/op, 5645853.7 op/s
// Warmup 4: 6000000 op, 1076.4 ms, 1076442969.3 ns, 2412313 ticks, 179.4072 ns/op, 5573913.5 op/s
// Warmup 5: 6000000 op, 1070.5 ms, 1070459490.5 ns, 2398904 ticks, 178.4099 ns/op, 5605069.6 op/s
Target 1: 6000000 op, 1030.5 ms, 1030455545.8 ns, 2309255 ticks, 171.7426 ns/op, 5822667.5 op/s
Target 2: 6000000 op, 1021.5 ms, 1021513125.4 ns, 2289215 ticks, 170.2522 ns/op, 5873639.7 op/s
Target 3: 6000000 op, 1068 ms, 1068035130.7 ns, 2393471 ticks, 178.0059 ns/op, 5617792.7 op/s
Target 4: 6000000 op, 1036.8 ms, 1036754954.5 ns, 2323372 ticks, 172.7925 ns/op, 5787288.5 op/s
Target 5: 6000000 op, 1072.4 ms, 1072444761.4 ns, 2403353 ticks, 178.7408 ns/op, 5594693.7 op/s
Target 6: 6000000 op, 984 ms, 983989319.1 ns, 2205124 ticks, 163.9982 ns/op, 6097627.2 op/s
Target 7: 6000000 op, 980.5 ms, 980518107.1 ns, 2197345 ticks, 163.4197 ns/op, 6119213.9 op/s
Target 8: 6000000 op, 976.5 ms, 976523468.9 ns, 2188393 ticks, 162.7539 ns/op, 6144245.6 op/s
Target 9: 6000000 op, 983 ms, 982968348.1 ns, 2202836 ticks, 163.8281 ns/op, 6103960.5 op/s
Target 10: 6000000 op, 1001.4 ms, 1001412313.4 ns, 2244169 ticks, 166.9021 ns/op, 5991538.1 op/s
// Benchmark finished

AverageTime (ns/op): Avr=170.095157251111 +- 3.38716742020587
OperationsPerSecond: Avr=5894820.37787879 +- 105380.407038192

// **************************
// Benchmark: SimpleComparisonTest_ManualCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 4016.1 ns, 9 ticks, 4016.0571 ns/op, 249000.4 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 83891 ns, 188 ticks, 83.891 ns/op, 11920234 op/s
// Pre-Warmup: 1000000 op, 95.3 ms, 95303265.9 ns, 213575 ticks, 95.3033 ns/op, 10492819.9 op/s
// Pre-Warmup: 11000000 op, 1000.9 ms, 1000888441.1 ns, 2242995 ticks, 90.9899 ns/op, 10990235.8 op/s
// Warmup (idle): 11000000 op, 32 ms, 31993249.5 ns, 71697 ticks, 2.9085 ns/op, 343822530.9 op/s
// Warmup (idle): 11000000 op, 31.8 ms, 31822343.9 ns, 71314 ticks, 2.8929 ns/op, 345669069.2 op/s
// Warmup (idle): 11000000 op, 35 ms, 35024480.1 ns, 78490 ticks, 3.184 ns/op, 314066046.6 op/s
// IterationCount = 11387163
// Target (idle): 11387163 op, 35.6 ms, 35623318.8 ns, 79832 ticks, 3.1284 ns/op, 319654747.9 op/s
// Target (idle): 11387163 op, 34.1 ms, 34118636.1 ns, 76460 ticks, 2.9962 ns/op, 333751998.8 op/s
// Target (idle): 11387163 op, 32.8 ms, 32763440 ns, 73423 ticks, 2.8772 ns/op, 347557003 op/s
// Target (idle): 11387163 op, 32.3 ms, 32331936.9 ns, 72456 ticks, 2.8393 ns/op, 352195509.4 op/s
// Target (idle): 11387163 op, 32.8 ms, 32800923.2 ns, 73507 ticks, 2.8805 ns/op, 347159832.8 op/s
// Warmup 1: 11387163 op, 1002.6 ms, 1002565814.3 ns, 2246754 ticks, 88.0435 ns/op, 11358020.4 op/s
// Warmup 2: 11387163 op, 1012.3 ms, 1012273516.7 ns, 2268509 ticks, 88.896 ns/op, 11249097 op/s
// Warmup 3: 11387163 op, 1002.4 ms, 1002432391.9 ns, 2246455 ticks, 88.0318 ns/op, 11359532.2 op/s
// Warmup 4: 11387163 op, 965 ms, 964966595.3 ns, 2162494 ticks, 84.7416 ns/op, 11800577.4 op/s
// Warmup 5: 11387163 op, 956.5 ms, 956524397.1 ns, 2143575 ticks, 84.0002 ns/op, 11904728.2 op/s
Target 1: 11387163 op, 938.2 ms, 938216977.7 ns, 2102548 ticks, 82.3925 ns/op, 12137025.1 op/s
Target 2: 11387163 op, 1068.6 ms, 1068636646.8 ns, 2394819 ticks, 93.8457 ns/op, 10655785.6 op/s
Target 3: 11387163 op, 1013 ms, 1013039691.1 ns, 2270226 ticks, 88.9633 ns/op, 11240589.2 op/s
Target 4: 11387163 op, 976.9 ms, 976937122.8 ns, 2189320 ticks, 85.7928 ns/op, 11655983.5 op/s
Target 5: 11387163 op, 1020.2 ms, 1020226202.2 ns, 2286331 ticks, 89.5944 ns/op, 11161410.1 op/s
Target 6: 11387163 op, 999.2 ms, 999193218.8 ns, 2239196 ticks, 87.7473 ns/op, 11396357.4 op/s
Target 7: 11387163 op, 958.7 ms, 958722519 ns, 2148501 ticks, 84.1933 ns/op, 11877433.5 op/s
Target 8: 11387163 op, 948.2 ms, 948157611.5 ns, 2124825 ticks, 83.2655 ns/op, 12009778.6 op/s
Target 9: 11387163 op, 933.5 ms, 933457950.1 ns, 2091883 ticks, 81.9746 ns/op, 12198903 op/s
Target 10: 11387163 op, 955.7 ms, 955686826.1 ns, 2141698 ticks, 83.9267 ns/op, 11915161.6 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 8032.1 ns, 18 ticks, 8032.1142 ns/op, 124500.2 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 129406.3 ns, 290 ticks, 129.4063 ns/op, 7727600 op/s
// Pre-Warmup: 1000000 op, 118.3 ms, 118261725.5 ns, 265025 ticks, 118.2617 ns/op, 8455821.1 op/s
// Pre-Warmup: 9000000 op, 839.2 ms, 839225186.6 ns, 1880707 ticks, 93.2472 ns/op, 10724177.7 op/s
// Pre-Warmup: 18000000 op, 1640.3 ms, 1640303631.8 ns, 3675927 ticks, 91.128 ns/op, 10973578.1 op/s
// Warmup (idle): 18000000 op, 54.2 ms, 54180180 ns, 121418 ticks, 3.01 ns/op, 332224810.2 op/s
// Warmup (idle): 18000000 op, 56.1 ms, 56078436.3 ns, 125672 ticks, 3.1155 ns/op, 320978992.9 op/s
// Warmup (idle): 18000000 op, 53.8 ms, 53849970.8 ns, 120678 ticks, 2.9917 ns/op, 334262019.6 op/s
// IterationCount = 18000000
// Target (idle): 18000000 op, 51.5 ms, 51488083 ns, 115385 ticks, 2.8604 ns/op, 349595458.7 op/s
// Target (idle): 18000000 op, 51.4 ms, 51415347.8 ns, 115222 ticks, 2.8564 ns/op, 350090017.5 op/s
// Target (idle): 18000000 op, 54.9 ms, 54866033.3 ns, 122955 ticks, 3.0481 ns/op, 328071831.2 op/s
// Target (idle): 18000000 op, 51.2 ms, 51177954.2 ns, 114690 ticks, 2.8432 ns/op, 351713941.9 op/s
// Target (idle): 18000000 op, 51.1 ms, 51053010.2 ns, 114410 ticks, 2.8363 ns/op, 352574705 op/s
// Warmup 1: 18000000 op, 1598.5 ms, 1598507187 ns, 3582261 ticks, 88.806 ns/op, 11260506.1 op/s
// Warmup 2: 18000000 op, 1754.5 ms, 1754546176.6 ns, 3931945 ticks, 97.4748 ns/op, 10259063.1 op/s
// Warmup 3: 18000000 op, 1652.2 ms, 1652167510.6 ns, 3702514 ticks, 91.7871 ns/op, 10894779.1 op/s
// Warmup 4: 18000000 op, 1601.2 ms, 1601219364.2 ns, 3588339 ticks, 88.9566 ns/op, 11241432.9 op/s
// Warmup 5: 18000000 op, 1582.6 ms, 1582585305.5 ns, 3546580 ticks, 87.9214 ns/op, 11373794.5 op/s
Target 1: 18000000 op, 1536.2 ms, 1536190475.3 ns, 3442609 ticks, 85.3439 ns/op, 11717297 op/s
Target 2: 18000000 op, 1486 ms, 1486029922.3 ns, 3330199 ticks, 82.5572 ns/op, 12112811.3 op/s
Target 3: 18000000 op, 1651.9 ms, 1651949751.1 ns, 3702026 ticks, 91.775 ns/op, 10896215.2 op/s
Target 4: 18000000 op, 1650.3 ms, 1650342882 ns, 3698425 ticks, 91.6857 ns/op, 10906824.4 op/s
Target 5: 18000000 op, 1589.5 ms, 1589535761.6 ns, 3562156 ticks, 88.3075 ns/op, 11324061 op/s
Target 6: 18000000 op, 1589.4 ms, 1589441161.2 ns, 3561944 ticks, 88.3023 ns/op, 11324735 op/s
Target 7: 18000000 op, 1580.4 ms, 1580389414.7 ns, 3541659 ticks, 87.7994 ns/op, 11389597.9 op/s
Target 8: 18000000 op, 1601.1 ms, 1601108699.5 ns, 3588091 ticks, 88.9505 ns/op, 11242209.9 op/s
Target 9: 18000000 op, 1651.7 ms, 1651666842.2 ns, 3701392 ticks, 91.7593 ns/op, 10898081.6 op/s
Target 10: 18000000 op, 1585.6 ms, 1585550494.3 ns, 3553225 ticks, 88.0861 ns/op, 11352524 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 4908.5 ns, 11 ticks, 4908.5142 ns/op, 203727.6 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 90138.2 ns, 202 ticks, 90.1382 ns/op, 11094079.2 op/s
// Pre-Warmup: 1000000 op, 89.4 ms, 89420188.5 ns, 200391 ticks, 89.4202 ns/op, 11183156.9 op/s
// Pre-Warmup: 12000000 op, 1139.5 ms, 1139495958.1 ns, 2553615 ticks, 94.958 ns/op, 10530972 op/s
// Warmup (idle): 12000000 op, 34.1 ms, 34120421 ns, 76464 ticks, 2.8434 ns/op, 351695543 op/s
// Warmup (idle): 12000000 op, 34.2 ms, 34153441.9 ns, 76538 ticks, 2.8461 ns/op, 351355509.7 op/s
// Warmup (idle): 12000000 op, 34.1 ms, 34074905.7 ns, 76362 ticks, 2.8396 ns/op, 352165317.8 op/s
// IterationCount = 12000000
// Target (idle): 12000000 op, 33.9 ms, 33883027.4 ns, 75932 ticks, 2.8236 ns/op, 354159616.5 op/s
// Target (idle): 12000000 op, 37.3 ms, 37316756.2 ns, 83627 ticks, 3.1097 ns/op, 321571358.5 op/s
// Target (idle): 12000000 op, 34.9 ms, 34889719.1 ns, 78188 ticks, 2.9075 ns/op, 343940860.5 op/s
// Target (idle): 12000000 op, 33.9 ms, 33906231.3 ns, 75984 ticks, 2.8255 ns/op, 353917245.7 op/s
// Target (idle): 12000000 op, 34.4 ms, 34372986.4 ns, 77030 ticks, 2.8644 ns/op, 349111359.2 op/s
// Warmup 1: 12000000 op, 989.3 ms, 989257493.5 ns, 2216930 ticks, 82.4381 ns/op, 12130309.9 op/s
// Warmup 2: 12000000 op, 1015.8 ms, 1015756330.6 ns, 2276314 ticks, 84.6464 ns/op, 11813857 op/s
// Warmup 3: 12000000 op, 990.8 ms, 990752359.2 ns, 2220280 ticks, 82.5627 ns/op, 12112007.5 op/s
// Warmup 4: 12000000 op, 1004.5 ms, 1004478349.9 ns, 2251040 ticks, 83.7065 ns/op, 11946499.4 op/s
// Warmup 5: 12000000 op, 1102.3 ms, 1102321995 ns, 2470308 ticks, 91.8602 ns/op, 10886111.4 op/s
Target 1: 12000000 op, 1061.5 ms, 1061459060.3 ns, 2378734 ticks, 88.4549 ns/op, 11305193.4 op/s
Target 2: 12000000 op, 1063.2 ms, 1063225233 ns, 2382692 ticks, 88.6021 ns/op, 11286413.9 op/s
Target 3: 12000000 op, 1054.8 ms, 1054838367.1 ns, 2363897 ticks, 87.9032 ns/op, 11376150.5 op/s
Target 4: 12000000 op, 1052.7 ms, 1052700486 ns, 2359106 ticks, 87.725 ns/op, 11399253.8 op/s
Target 5: 12000000 op, 1087.9 ms, 1087875791.4 ns, 2437934 ticks, 90.6563 ns/op, 11030671.1 op/s
Target 6: 12000000 op, 1069 ms, 1069043161 ns, 2395730 ticks, 89.0869 ns/op, 11224991.1 op/s
Target 7: 12000000 op, 1040.1 ms, 1040062400.6 ns, 2330784 ticks, 86.6719 ns/op, 11537769.3 op/s
Target 8: 12000000 op, 982.9 ms, 982904091.2 ns, 2202692 ticks, 81.9087 ns/op, 12208719.1 op/s
Target 9: 12000000 op, 993.2 ms, 993224911.7 ns, 2225821 ticks, 82.7687 ns/op, 12081855.6 op/s
Target 10: 12000000 op, 998.1 ms, 998134764.6 ns, 2236824 ticks, 83.1779 ns/op, 12022424.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=87.1072942575261 +- 1.18512679227332
OperationsPerSecond: Avr=11496207.577799 +- 156995.910095699

// **************************
// Benchmark: SimpleComparisonTest_ReflectionCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 34359.6 ns, 77 ticks, 34359.5995 ns/op, 29103.9 op/s
// Pre-Warmup: 1000 op, 8.6 ms, 8571158.3 ns, 19208 ticks, 8571.1583 ns/op, 116670.3 op/s
// Pre-Warmup: 117000 op, 852.7 ms, 852741896 ns, 1910998 ticks, 7288.3923 ns/op, 137204.5 op/s
// Pre-Warmup: 234000 op, 1723.7 ms, 1723711336.5 ns, 3862844 ticks, 7366.2878 ns/op, 135753.6 op/s
// Warmup (idle): 234000 op, 0.8 ms, 771083 ns, 1728 ticks, 3.2952 ns/op, 303469291.7 op/s
// Warmup (idle): 234000 op, 0.8 ms, 760373.5 ns, 1704 ticks, 3.2495 ns/op, 307743507 op/s
// Warmup (idle): 234000 op, 0.8 ms, 761265.9 ns, 1706 ticks, 3.2533 ns/op, 307382729.2 op/s
// IterationCount = 234000
// Target (idle): 234000 op, 0.8 ms, 775991.5 ns, 1739 ticks, 3.3162 ns/op, 301549704.4 op/s
// Target (idle): 234000 op, 0.8 ms, 832216.3 ns, 1865 ticks, 3.5565 ns/op, 281176909.4 op/s
// Target (idle): 234000 op, 0.8 ms, 761712.2 ns, 1707 ticks, 3.2552 ns/op, 307202657.3 op/s
// Target (idle): 234000 op, 0.8 ms, 761265.9 ns, 1706 ticks, 3.2533 ns/op, 307382729.2 op/s
// Target (idle): 234000 op, 0.8 ms, 755018.7 ns, 1692 ticks, 3.2266 ns/op, 309926085.1 op/s
// Warmup 1: 234000 op, 1697.3 ms, 1697279879.9 ns, 3803611 ticks, 7253.3328 ns/op, 137867.7 op/s
// Warmup 2: 234000 op, 1724.4 ms, 1724404329.5 ns, 3864397 ticks, 7369.2493 ns/op, 135699 op/s
// Warmup 3: 234000 op, 1714.7 ms, 1714703766.7 ns, 3842658 ticks, 7327.7939 ns/op, 136466.7 op/s
// Warmup 4: 234000 op, 1632.8 ms, 1632775309.6 ns, 3659056 ticks, 6977.6723 ns/op, 143314.3 op/s
// Warmup 5: 234000 op, 1526 ms, 1526019587.6 ns, 3419816 ticks, 6521.4512 ns/op, 153340.1 op/s
Target 1: 234000 op, 1526.5 ms, 1526520256.1 ns, 3420938 ticks, 6523.5908 ns/op, 153289.8 op/s
Target 2: 234000 op, 1518.9 ms, 1518940617.7 ns, 3403952 ticks, 6491.1992 ns/op, 154054.7 op/s
Target 3: 234000 op, 1681.2 ms, 1681202710.9 ns, 3767582 ticks, 7184.627 ns/op, 139186.1 op/s
Target 4: 234000 op, 1708.8 ms, 1708793915.6 ns, 3829414 ticks, 7302.5381 ns/op, 136938.7 op/s
Target 5: 234000 op, 1710.1 ms, 1710120553.1 ns, 3832387 ticks, 7308.2075 ns/op, 136832.5 op/s
Target 6: 234000 op, 1723.1 ms, 1723116067.6 ns, 3861510 ticks, 7363.7439 ns/op, 135800.5 op/s
Target 7: 234000 op, 1702.5 ms, 1702535113.7 ns, 3815388 ticks, 7275.7911 ns/op, 137442.1 op/s
Target 8: 234000 op, 1724.4 ms, 1724379786.9 ns, 3864342 ticks, 7369.1444 ns/op, 135701 op/s
Target 9: 234000 op, 1683.3 ms, 1683335683.5 ns, 3772362 ticks, 7193.7422 ns/op, 139009.7 op/s
Target 10: 234000 op, 1707.3 ms, 1707257996.9 ns, 3825972 ticks, 7295.9743 ns/op, 137061.9 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 45515.3 ns, 102 ticks, 45515.3137 ns/op, 21970.6 op/s
// Pre-Warmup: 1000 op, 8.4 ms, 8372140.3 ns, 18762 ticks, 8372.1403 ns/op, 119443.8 op/s
// Pre-Warmup: 120000 op, 836.4 ms, 836383156.8 ns, 1874338 ticks, 6969.8596 ns/op, 143474.9 op/s
// Pre-Warmup: 240000 op, 1497.4 ms, 1497405180.9 ns, 3355691 ticks, 6239.1883 ns/op, 160277.3 op/s
// Warmup (idle): 240000 op, 0.8 ms, 829538.9 ns, 1859 ticks, 3.4564 ns/op, 289317353.4 op/s
// Warmup (idle): 240000 op, 0.8 ms, 811243.5 ns, 1818 ticks, 3.3802 ns/op, 295842112.2 op/s
// Warmup (idle): 240000 op, 0.8 ms, 809458.6 ns, 1814 ticks, 3.3727 ns/op, 296494465.3 op/s
// IterationCount = 240000
// Target (idle): 240000 op, 0.8 ms, 808119.9 ns, 1811 ticks, 3.3672 ns/op, 296985621.2 op/s
// Target (idle): 240000 op, 0.8 ms, 806781.2 ns, 1808 ticks, 3.3616 ns/op, 297478407.1 op/s
// Target (idle): 240000 op, 0.8 ms, 806781.2 ns, 1808 ticks, 3.3616 ns/op, 297478407.1 op/s
// Target (idle): 240000 op, 0.8 ms, 780453.8 ns, 1749 ticks, 3.2519 ns/op, 307513413.4 op/s
// Target (idle): 240000 op, 0.8 ms, 774652.8 ns, 1736 ticks, 3.2277 ns/op, 309816221.2 op/s
// Warmup 1: 240000 op, 1545.4 ms, 1545364934.6 ns, 3463169 ticks, 6439.0206 ns/op, 155303.1 op/s
// Warmup 2: 240000 op, 1900 ms, 1900034091.9 ns, 4257984 ticks, 7916.8087 ns/op, 126313.5 op/s
// Warmup 3: 240000 op, 1668 ms, 1668023350.2 ns, 3738047 ticks, 6950.0973 ns/op, 143882.9 op/s
// Warmup 4: 240000 op, 1680 ms, 1680008157.1 ns, 3764905 ticks, 7000.034 ns/op, 142856.4 op/s
// Warmup 5: 240000 op, 1764.3 ms, 1764258787.6 ns, 3953711 ticks, 7351.0783 ns/op, 136034.5 op/s
Target 1: 240000 op, 1747.1 ms, 1747129857.9 ns, 3915325 ticks, 7279.7077 ns/op, 137368.2 op/s
Target 2: 240000 op, 1629.1 ms, 1629090354.1 ns, 3650798 ticks, 6787.8765 ns/op, 147321.5 op/s
Target 3: 240000 op, 1488.3 ms, 1488288285.1 ns, 3335260 ticks, 6201.2012 ns/op, 161259.1 op/s
Target 4: 240000 op, 1513.3 ms, 1513321261.4 ns, 3391359 ticks, 6305.5053 ns/op, 158591.6 op/s
Target 5: 240000 op, 1496.9 ms, 1496871045.3 ns, 3354494 ticks, 6236.9627 ns/op, 160334.5 op/s
Target 6: 240000 op, 1650.8 ms, 1650845335.4 ns, 3699551 ticks, 6878.5222 ns/op, 145380.1 op/s
Target 7: 240000 op, 1661.5 ms, 1661544557.7 ns, 3723528 ticks, 6923.1023 ns/op, 144443.9 op/s
Target 8: 240000 op, 1700.2 ms, 1700178134.4 ns, 3810106 ticks, 7084.0756 ns/op, 141161.7 op/s
Target 9: 240000 op, 1664.6 ms, 1664649416.1 ns, 3730486 ticks, 6936.0392 ns/op, 144174.5 op/s
Target 10: 240000 op, 1657.3 ms, 1657326805.3 ns, 3714076 ticks, 6905.5284 ns/op, 144811.5 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 42837.9 ns, 96 ticks, 42837.9423 ns/op, 23343.8 op/s
// Pre-Warmup: 1000 op, 7.4 ms, 7369464.8 ns, 16515 ticks, 7369.4648 ns/op, 135695.1 op/s
// Pre-Warmup: 136000 op, 986.4 ms, 986426173.3 ns, 2210585 ticks, 7253.1336 ns/op, 137871.4 op/s
// Pre-Warmup: 272000 op, 1882.9 ms, 1882858754.4 ns, 4219494 ticks, 6922.2748 ns/op, 144461.2 op/s
// Warmup (idle): 272000 op, 1 ms, 1025879.5 ns, 2299 ticks, 3.7716 ns/op, 265138359.3 op/s
// Warmup (idle): 272000 op, 1 ms, 1004460.5 ns, 2251 ticks, 3.6929 ns/op, 270792131.5 op/s
// Warmup (idle): 272000 op, 0.9 ms, 894242 ns, 2004 ticks, 3.2877 ns/op, 304168207.6 op/s
// IterationCount = 272000
// Target (idle): 272000 op, 0.9 ms, 893795.8 ns, 2003 ticks, 3.286 ns/op, 304320063.9 op/s
// Target (idle): 272000 op, 0.9 ms, 880409 ns, 1973 ticks, 3.2368 ns/op, 308947333 op/s
// Target (idle): 272000 op, 0.9 ms, 877731.6 ns, 1967 ticks, 3.227 ns/op, 309889724.5 op/s
// Target (idle): 272000 op, 0.9 ms, 879962.7 ns, 1972 ticks, 3.2352 ns/op, 309104000 op/s
// Target (idle): 272000 op, 0.9 ms, 879070.3 ns, 1970 ticks, 3.2319 ns/op, 309417811.2 op/s
// Warmup 1: 272000 op, 1707.6 ms, 1707628366.6 ns, 3826802 ticks, 6278.0455 ns/op, 159285.2 op/s
// Warmup 2: 272000 op, 1704.9 ms, 1704897894 ns, 3820683 ticks, 6268.007 ns/op, 159540.3 op/s
// Warmup 3: 272000 op, 1731.2 ms, 1731249921.9 ns, 3879738 ticks, 6364.8894 ns/op, 157111.9 op/s
// Warmup 4: 272000 op, 1837.8 ms, 1837846340.3 ns, 4118621 ticks, 6756.788 ns/op, 147999.3 op/s
// Warmup 5: 272000 op, 1939.9 ms, 1939905506.6 ns, 4347336 ticks, 7132.0055 ns/op, 140213 op/s
Target 1: 272000 op, 1845.1 ms, 1845055162.8 ns, 4134776 ticks, 6783.291 ns/op, 147421.1 op/s
Target 2: 272000 op, 1928.3 ms, 1928258494.9 ns, 4321235 ticks, 7089.1856 ns/op, 141059.9 op/s
Target 3: 272000 op, 1908.3 ms, 1908346883.8 ns, 4276613 ticks, 7015.9812 ns/op, 142531.7 op/s
Target 4: 272000 op, 1865 ms, 1864987746.6 ns, 4179445 ticks, 6856.5726 ns/op, 145845.5 op/s
Target 5: 272000 op, 1760.2 ms, 1760176688.7 ns, 3944563 ticks, 6471.2378 ns/op, 154529.9 op/s
Target 6: 272000 op, 1681.3 ms, 1681288833 ns, 3767775 ticks, 6181.2089 ns/op, 161780.6 op/s
Target 7: 272000 op, 1681.5 ms, 1681534705 ns, 3768326 ticks, 6182.1129 ns/op, 161757 op/s
Target 8: 272000 op, 1934.8 ms, 1934768969.6 ns, 4335825 ticks, 7113.1212 ns/op, 140585.3 op/s
Target 9: 272000 op, 1896.7 ms, 1896723522.1 ns, 4250565 ticks, 6973.2482 ns/op, 143405.2 op/s
Target 10: 272000 op, 1905.8 ms, 1905821230.1 ns, 4270953 ticks, 7006.6957 ns/op, 142720.6 op/s
// Benchmark finished

AverageTime (ns/op): Avr=6883.99116300299 +- 138.550699815001
OperationsPerSecond: Avr=145726.672539296 +- 3045.04873913938

// **************************
// Benchmark: SimpleComparisonTest_DynamicCodeCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_DynamicCodeCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=DynamicCodeCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 16064.2 ns, 36 ticks, 16064.2284 ns/op, 62250.1 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 207496.3 ns, 465 ticks, 207.4963 ns/op, 4819363.4 op/s
// Pre-Warmup: 1000000 op, 183.6 ms, 183573969.5 ns, 411390 ticks, 183.574 ns/op, 5447395.4 op/s
// Pre-Warmup: 6000000 op, 1100.6 ms, 1100563854.4 ns, 2466368 ticks, 183.4273 ns/op, 5451750.9 op/s
// Warmup (idle): 6000000 op, 18.8 ms, 18786222.6 ns, 42100 ticks, 3.131 ns/op, 319382992.9 op/s
// Warmup (idle): 6000000 op, 18.1 ms, 18076273 ns, 40509 ticks, 3.0127 ns/op, 331926831.1 op/s
// Warmup (idle): 6000000 op, 18 ms, 18009784.9 ns, 40360 ticks, 3.0016 ns/op, 333152229.9 op/s
// IterationCount = 6000000
// Target (idle): 6000000 op, 17.3 ms, 17306974.9 ns, 38785 ticks, 2.8845 ns/op, 346681036.5 op/s
// Target (idle): 6000000 op, 17.3 ms, 17251196.3 ns, 38660 ticks, 2.8752 ns/op, 347801965.9 op/s
// Target (idle): 6000000 op, 17.3 ms, 17304297.5 ns, 38779 ticks, 2.884 ns/op, 346734676 op/s
// Target (idle): 6000000 op, 17.3 ms, 17348027.9 ns, 38877 ticks, 2.8913 ns/op, 345860637.4 op/s
// Target (idle): 6000000 op, 17 ms, 16959362.9 ns, 38006 ticks, 2.8266 ns/op, 353786875.8 op/s
// Warmup 1: 6000000 op, 1085.4 ms, 1085396991.7 ns, 2432379 ticks, 180.8995 ns/op, 5527931.3 op/s
// Warmup 2: 6000000 op, 1059.2 ms, 1059168569.1 ns, 2373601 ticks, 176.5281 ns/op, 5664820.7 op/s
// Warmup 3: 6000000 op, 1003.4 ms, 1003356085 ns, 2248525 ticks, 167.226 ns/op, 5979930.8 op/s
// Warmup 4: 6000000 op, 1003.5 ms, 1003512265 ns, 2248875 ticks, 167.252 ns/op, 5979000.2 op/s
// Warmup 5: 6000000 op, 1000.4 ms, 1000368138.6 ns, 2241829 ticks, 166.728 ns/op, 5997792 op/s
Target 1: 6000000 op, 999.1 ms, 999084339 ns, 2238952 ticks, 166.5141 ns/op, 6005499 op/s
Target 2: 6000000 op, 1081.8 ms, 1081783432.8 ns, 2424281 ticks, 180.2972 ns/op, 5546396.6 op/s
Target 3: 6000000 op, 1113.1 ms, 1113106893.2 ns, 2494477 ticks, 185.5178 ns/op, 5390317.9 op/s
Target 4: 6000000 op, 1095.4 ms, 1095360829.3 ns, 2454708 ticks, 182.5601 ns/op, 5477647 op/s
Target 5: 6000000 op, 1086 ms, 1086045361.8 ns, 2433832 ticks, 181.0076 ns/op, 5524631.1 op/s
Target 6: 6000000 op, 1094.4 ms, 1094352352.8 ns, 2452448 ticks, 182.3921 ns/op, 5482694.8 op/s
Target 7: 6000000 op, 1076.5 ms, 1076467065.7 ns, 2412367 ticks, 179.4112 ns/op, 5573788.7 op/s
Target 8: 6000000 op, 1060.6 ms, 1060592038.2 ns, 2376791 ticks, 176.7653 ns/op, 5657217.7 op/s
Target 9: 6000000 op, 1135.9 ms, 1135869458.5 ns, 2545488 ticks, 189.3116 ns/op, 5282297.1 op/s
Target 10: 6000000 op, 1068.6 ms, 1068569266.3 ns, 2394668 ticks, 178.0949 ns/op, 5614984.6 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=DynamicCodeCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 29004.9 ns, 65 ticks, 29004.8568 ns/op, 34477 op/s
// Pre-Warmup: 1000 op, 0.3 ms, 314591.1 ns, 705 ticks, 314.5911 ns/op, 3178729.1 op/s
// Pre-Warmup: 1000000 op, 206.9 ms, 206949206.7 ns, 463774 ticks, 206.9492 ns/op, 4832103.6 op/s
// Pre-Warmup: 5000000 op, 988.8 ms, 988835807.5 ns, 2215985 ticks, 197.7672 ns/op, 5056451.2 op/s
// Pre-Warmup: 10000000 op, 1837.9 ms, 1837926215.2 ns, 4118800 ticks, 183.7926 ns/op, 5440914.8 op/s
// Warmup (idle): 10000000 op, 30.9 ms, 30880355.4 ns, 69203 ticks, 3.088 ns/op, 323830469.8 op/s
// Warmup (idle): 10000000 op, 31.7 ms, 31712571.7 ns, 71068 ticks, 3.1713 ns/op, 315332357.7 op/s
// Warmup (idle): 10000000 op, 29.8 ms, 29841535.3 ns, 66875 ticks, 2.9842 ns/op, 335103401.9 op/s
// IterationCount = 10000000
// Target (idle): 10000000 op, 29.7 ms, 29717037.5 ns, 66596 ticks, 2.9717 ns/op, 336507297.7 op/s
// Target (idle): 10000000 op, 29.1 ms, 29148542.3 ns, 65322 ticks, 2.9149 ns/op, 343070328.5 op/s
// Target (idle): 10000000 op, 28.3 ms, 28289552.4 ns, 63397 ticks, 2.829 ns/op, 353487389 op/s
// Target (idle): 10000000 op, 28.7 ms, 28729980 ns, 64384 ticks, 2.873 ns/op, 348068464.2 op/s
// Target (idle): 10000000 op, 29.4 ms, 29417618.2 ns, 65925 ticks, 2.9418 ns/op, 339932347.4 op/s
// Warmup 1: 10000000 op, 1765.2 ms, 1765227996 ns, 3955883 ticks, 176.5228 ns/op, 5664990.6 op/s
// Warmup 2: 10000000 op, 1690.9 ms, 1690945665.4 ns, 3789416 ticks, 169.0946 ns/op, 5913850.6 op/s
// Warmup 3: 10000000 op, 1688.2 ms, 1688216531.5 ns, 3783300 ticks, 168.8217 ns/op, 5923410.8 op/s
// Warmup 4: 10000000 op, 1769.4 ms, 1769437716.3 ns, 3965317 ticks, 176.9438 ns/op, 5651512.9 op/s
// Warmup 5: 10000000 op, 1796.9 ms, 1796949938.5 ns, 4026972 ticks, 179.695 ns/op, 5564985.3 op/s
Target 1: 10000000 op, 1789.3 ms, 1789347096.2 ns, 4009934 ticks, 178.9347 ns/op, 5588630.6 op/s
Target 2: 10000000 op, 1804.7 ms, 1804712084.4 ns, 4044367 ticks, 180.4712 ns/op, 5541050.1 op/s
Target 3: 10000000 op, 1817.7 ms, 1817727233 ns, 4073534 ticks, 181.7727 ns/op, 5501375.5 op/s
Target 4: 10000000 op, 1838.9 ms, 1838897654.8 ns, 4120977 ticks, 183.8898 ns/op, 5438040.5 op/s
Target 5: 10000000 op, 1810 ms, 1809992753.2 ns, 4056201 ticks, 180.9993 ns/op, 5524884 op/s
Target 6: 10000000 op, 1816 ms, 1815972662.3 ns, 4069602 ticks, 181.5973 ns/op, 5506690.8 op/s
Target 7: 10000000 op, 1807.4 ms, 1807445680.6 ns, 4050493 ticks, 180.7446 ns/op, 5532669.7 op/s
Target 8: 10000000 op, 1818.1 ms, 1818103403.7 ns, 4074377 ticks, 181.8103 ns/op, 5500237.2 op/s
Target 9: 10000000 op, 1829 ms, 1828978886.2 ns, 4098749 ticks, 182.8979 ns/op, 5467531.7 op/s
Target 10: 10000000 op, 1812.3 ms, 1812264949.1 ns, 4061293 ticks, 181.2265 ns/op, 5517957 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=DynamicCodeCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 23203.9 ns, 52 ticks, 23203.8854 ns/op, 43096.2 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 222221.8 ns, 498 ticks, 222.2218 ns/op, 4500008 op/s
// Pre-Warmup: 1000000 op, 183.6 ms, 183556120.4 ns, 411350 ticks, 183.5561 ns/op, 5447925.1 op/s
// Pre-Warmup: 6000000 op, 1014.9 ms, 1014924560.6 ns, 2274450 ticks, 169.1541 ns/op, 5911769.4 op/s
// Warmup (idle): 6000000 op, 17.1 ms, 17107064.5 ns, 38337 ticks, 2.8512 ns/op, 350732295.2 op/s
// Warmup (idle): 6000000 op, 17.1 ms, 17132499.5 ns, 38394 ticks, 2.8554 ns/op, 350211595.6 op/s
// Warmup (idle): 6000000 op, 18.1 ms, 18142761 ns, 40658 ticks, 3.0238 ns/op, 330710413.7 op/s
// IterationCount = 6018054
// Target (idle): 6018054 op, 18.6 ms, 18587650.9 ns, 41655 ticks, 3.0886 ns/op, 323766248.6 op/s
// Target (idle): 6018054 op, 18.5 ms, 18514915.6 ns, 41492 ticks, 3.0766 ns/op, 325038154 op/s
// Target (idle): 6018054 op, 17.4 ms, 17357845 ns, 38899 ticks, 2.8843 ns/op, 346705136 op/s
// Target (idle): 6018054 op, 17.1 ms, 17076274.7 ns, 38268 ticks, 2.8375 ns/op, 352421947.5 op/s
// Target (idle): 6018054 op, 17.4 ms, 17367662 ns, 38921 ticks, 2.8859 ns/op, 346509161.8 op/s
// Warmup 1: 6018054 op, 1004.7 ms, 1004657733.8 ns, 2251442 ticks, 166.9406 ns/op, 5990153.5 op/s
// Warmup 2: 6018054 op, 998.1 ms, 998134318.4 ns, 2236823 ticks, 165.8567 ns/op, 6029302.8 op/s
// Warmup 3: 6018054 op, 1011.6 ms, 1011618453.2 ns, 2267041 ticks, 168.0973 ns/op, 5948936.6 op/s
// Warmup 4: 6018054 op, 1042.4 ms, 1042391267.5 ns, 2336003 ticks, 173.2107 ns/op, 5773315.8 op/s
// Warmup 5: 6018054 op, 1076.2 ms, 1076171216.1 ns, 2411704 ticks, 178.8238 ns/op, 5592097.2 op/s
Target 1: 6018054 op, 1085.4 ms, 1085355046.2 ns, 2432285 ticks, 180.3498 ns/op, 5544779.1 op/s
Target 2: 6018054 op, 1083.6 ms, 1083633496.4 ns, 2428427 ticks, 180.0638 ns/op, 5553588 op/s
Target 3: 6018054 op, 1083.7 ms, 1083724973.3 ns, 2428632 ticks, 180.079 ns/op, 5553119.2 op/s
Target 4: 6018054 op, 1046.5 ms, 1046544316.7 ns, 2345310 ticks, 173.9008 ns/op, 5750405.3 op/s
Target 5: 6018054 op, 996.6 ms, 996576980.7 ns, 2233333 ticks, 165.5979 ns/op, 6038724.7 op/s
Target 6: 6018054 op, 1011.4 ms, 1011386414.3 ns, 2266521 ticks, 168.0587 ns/op, 5950301.4 op/s
Target 7: 6018054 op, 1011.6 ms, 1011571152.9 ns, 2266935 ticks, 168.0894 ns/op, 5949214.7 op/s
Target 8: 6018054 op, 998.2 ms, 998238289.6 ns, 2237056 ticks, 165.8739 ns/op, 6028674.8 op/s
Target 9: 6018054 op, 996.3 ms, 996318614.3 ns, 2232754 ticks, 165.5549 ns/op, 6040290.6 op/s
Target 10: 6018054 op, 1107.5 ms, 1107491106.7 ns, 2481892 ticks, 184.0281 ns/op, 5433952.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=178.260414611918 +- 2.32728717114454
OperationsPerSecond: Avr=5617253.07146638 +- 75965.7429900752

// **************************
// Benchmark: SimpleComparisonTest_ManualCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 3123.6 ns, 7 ticks, 3123.6 ns/op, 320143.4 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 99955.2 ns, 224 ticks, 99.9552 ns/op, 10004482.1 op/s
// Pre-Warmup: 1000000 op, 96.8 ms, 96790099.4 ns, 216907 ticks, 96.7901 ns/op, 10331635.2 op/s
// Pre-Warmup: 11000000 op, 1151.1 ms, 1151145201 ns, 2579721 ticks, 104.6496 ns/op, 9555701.6 op/s
// Warmup (idle): 11000000 op, 35.4 ms, 35392172.4 ns, 79314 ticks, 3.2175 ns/op, 310803187.3 op/s
// Warmup (idle): 11000000 op, 35.5 ms, 35458660.5 ns, 79463 ticks, 3.2235 ns/op, 310220404.5 op/s
// Warmup (idle): 11000000 op, 38.5 ms, 38488552.5 ns, 86253 ticks, 3.499 ns/op, 285799265 op/s
// IterationCount = 11000000
// Target (idle): 11000000 op, 35.1 ms, 35117741.9 ns, 78699 ticks, 3.1925 ns/op, 313231985.2 op/s
// Target (idle): 11000000 op, 35.7 ms, 35720596.7 ns, 80050 ticks, 3.2473 ns/op, 307945584 op/s
// Target (idle): 11000000 op, 35.1 ms, 35075796.4 ns, 78605 ticks, 3.1887 ns/op, 313606564.5 op/s
// Target (idle): 11000000 op, 34.8 ms, 34775038.3 ns, 77931 ticks, 3.1614 ns/op, 316318846.2 op/s
// Target (idle): 11000000 op, 36.3 ms, 36256070.9 ns, 81250 ticks, 3.296 ns/op, 303397464.6 op/s
// Warmup 1: 11000000 op, 1118 ms, 1118030132.9 ns, 2505510 ticks, 101.6391 ns/op, 9838733 op/s
// Warmup 2: 11000000 op, 1010.6 ms, 1010615777.6 ns, 2264794 ticks, 91.8742 ns/op, 10884453.1 op/s
// Warmup 3: 11000000 op, 1011.1 ms, 1011052635.3 ns, 2265773 ticks, 91.9139 ns/op, 10879750.1 op/s
// Warmup 4: 11000000 op, 1016.7 ms, 1016695641.8 ns, 2278419 ticks, 92.4269 ns/op, 10819363.8 op/s
// Warmup 5: 11000000 op, 1027.2 ms, 1027189152.7 ns, 2301935 ticks, 93.3808 ns/op, 10708835.8 op/s
Target 1: 11000000 op, 1033.4 ms, 1033411810.1 ns, 2315880 ticks, 93.9465 ns/op, 10644352.9 op/s
Target 2: 11000000 op, 1149.5 ms, 1149468720.3 ns, 2575964 ticks, 104.4972 ns/op, 9569638.4 op/s
Target 3: 11000000 op, 1085.3 ms, 1085345675.4 ns, 2432264 ticks, 98.6678 ns/op, 10135019.9 op/s
Target 4: 11000000 op, 1098.5 ms, 1098478628.3 ns, 2461695 ticks, 99.8617 ns/op, 10013849.8 op/s
Target 5: 11000000 op, 1085.7 ms, 1085700873.4 ns, 2433060 ticks, 98.7001 ns/op, 10131704.1 op/s
Target 6: 11000000 op, 1044 ms, 1044011077.2 ns, 2339633 ticks, 94.9101 ns/op, 10536286.7 op/s
Target 7: 11000000 op, 1014.4 ms, 1014390425 ns, 2273253 ticks, 92.2173 ns/op, 10843950.9 op/s
Target 8: 11000000 op, 1014.9 ms, 1014879045.3 ns, 2274348 ticks, 92.2617 ns/op, 10838730 op/s
Target 9: 11000000 op, 1006.1 ms, 1006131180.5 ns, 2254744 ticks, 91.4665 ns/op, 10932968 op/s
Target 10: 11000000 op, 1012.2 ms, 1012165529.4 ns, 2268267 ticks, 92.015 ns/op, 10867787.6 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 3123.6 ns, 7 ticks, 3123.6 ns/op, 320143.4 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 89691.9 ns, 201 ticks, 89.6919 ns/op, 11149273.6 op/s
// Pre-Warmup: 1000000 op, 94.7 ms, 94703980.9 ns, 212232 ticks, 94.704 ns/op, 10559218.2 op/s
// Pre-Warmup: 11000000 op, 1068.9 ms, 1068887427.2 ns, 2395381 ticks, 97.1716 ns/op, 10291074.4 op/s
// Warmup (idle): 11000000 op, 37.6 ms, 37617960.5 ns, 84302 ticks, 3.4198 ns/op, 292413513.3 op/s
// Warmup (idle): 11000000 op, 38.4 ms, 38359592.4 ns, 85964 ticks, 3.4872 ns/op, 286760085.6 op/s
// Warmup (idle): 11000000 op, 38 ms, 37953970.6 ns, 85055 ticks, 3.4504 ns/op, 289824748.7 op/s
// IterationCount = 11000000
// Target (idle): 11000000 op, 36.8 ms, 36765664 ns, 82392 ticks, 3.3423 ns/op, 299192203.1 op/s
// Target (idle): 11000000 op, 36.2 ms, 36177534.7 ns, 81074 ticks, 3.2889 ns/op, 304056096.9 op/s
// Target (idle): 11000000 op, 35.9 ms, 35919168.4 ns, 80495 ticks, 3.2654 ns/op, 306243170.4 op/s
// Target (idle): 11000000 op, 37.9 ms, 37850891.8 ns, 84824 ticks, 3.441 ns/op, 290614024.3 op/s
// Target (idle): 11000000 op, 35.2 ms, 35190030.9 ns, 78861 ticks, 3.1991 ns/op, 312588529.2 op/s
// Warmup 1: 11000000 op, 1030.3 ms, 1030318553.6 ns, 2308948 ticks, 93.6653 ns/op, 10676309.7 op/s
// Warmup 2: 11000000 op, 1054.7 ms, 1054692450.3 ns, 2363570 ticks, 95.8811 ns/op, 10429580.7 op/s
// Warmup 3: 11000000 op, 1054.7 ms, 1054692004.1 ns, 2363569 ticks, 95.8811 ns/op, 10429585.1 op/s
// Warmup 4: 11000000 op, 1039.6 ms, 1039595199.3 ns, 2329737 ticks, 94.5087 ns/op, 10581041.6 op/s
// Warmup 5: 11000000 op, 1039.7 ms, 1039658563.8 ns, 2329879 ticks, 94.5144 ns/op, 10580396.7 op/s
Target 1: 11000000 op, 1041.4 ms, 1041405994.8 ns, 2333795 ticks, 94.6733 ns/op, 10562643.2 op/s
Target 2: 11000000 op, 1045.6 ms, 1045593849.9 ns, 2343180 ticks, 95.054 ns/op, 10520337.3 op/s
Target 3: 11000000 op, 1051.8 ms, 1051813829.9 ns, 2357119 ticks, 95.6194 ns/op, 10458124.5 op/s
Target 4: 11000000 op, 983.3 ms, 983340056.5 ns, 2203669 ticks, 89.3946 ns/op, 11186364.2 op/s
Target 5: 11000000 op, 969.5 ms, 969512325.7 ns, 2172681 ticks, 88.1375 ns/op, 11345910.4 op/s
Target 6: 11000000 op, 972.5 ms, 972526599.7 ns, 2179436 ticks, 88.4115 ns/op, 11310744.6 op/s
Target 7: 11000000 op, 976.6 ms, 976632794.9 ns, 2188638 ticks, 88.7848 ns/op, 11263189.3 op/s
Target 8: 11000000 op, 970 ms, 969960339.2 ns, 2173685 ticks, 88.1782 ns/op, 11340669.9 op/s
Target 9: 11000000 op, 1058.9 ms, 1058903063.1 ns, 2373006 ticks, 96.2639 ns/op, 10388108.6 op/s
Target 10: 11000000 op, 1056.7 ms, 1056709403.5 ns, 2368090 ticks, 96.0645 ns/op, 10409673.6 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 3123.6 ns, 7 ticks, 3123.6 ns/op, 320143.4 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 89245.7 ns, 200 ticks, 89.2457 ns/op, 11205020 op/s
// Pre-Warmup: 1000000 op, 94.6 ms, 94628568.3 ns, 212063 ticks, 94.6286 ns/op, 10567633.2 op/s
// Pre-Warmup: 11000000 op, 1072.2 ms, 1072220308.4 ns, 2402850 ticks, 97.4746 ns/op, 10259085.7 op/s
// Warmup (idle): 11000000 op, 35.3 ms, 35344426 ns, 79207 ticks, 3.2131 ns/op, 311223048.5 op/s
// Warmup (idle): 11000000 op, 35.1 ms, 35091860.6 ns, 78641 ticks, 3.1902 ns/op, 313463002.8 op/s
// Warmup (idle): 11000000 op, 35.6 ms, 35612163.1 ns, 79807 ticks, 3.2375 ns/op, 308883230.8 op/s
// IterationCount = 11000000
// Target (idle): 11000000 op, 35.9 ms, 35924076.9 ns, 80506 ticks, 3.2658 ns/op, 306201326.6 op/s
// Target (idle): 11000000 op, 37.8 ms, 37796451.9 ns, 84702 ticks, 3.436 ns/op, 291032608.4 op/s
// Target (idle): 11000000 op, 37.1 ms, 37104351.4 ns, 83151 ticks, 3.3731 ns/op, 296461185.1 op/s
// Target (idle): 11000000 op, 35.4 ms, 35372984.6 ns, 79271 ticks, 3.2157 ns/op, 310971780.3 op/s
// Target (idle): 11000000 op, 35.2 ms, 35167719.5 ns, 78811 ticks, 3.1971 ns/op, 312786844.5 op/s
// Warmup 1: 11000000 op, 1025.9 ms, 1025948191.1 ns, 2299154 ticks, 93.268 ns/op, 10721789 op/s
// Warmup 2: 11000000 op, 1052.5 ms, 1052492543.5 ns, 2358640 ticks, 95.6811 ns/op, 10451380.5 op/s
// Warmup 3: 11000000 op, 1041.2 ms, 1041170832.4 ns, 2333268 ticks, 94.6519 ns/op, 10565029 op/s
// Warmup 4: 11000000 op, 971.4 ms, 971391394.2 ns, 2176892 ticks, 88.3083 ns/op, 11323962.8 op/s
// Warmup 5: 11000000 op, 998.6 ms, 998571622.4 ns, 2237803 ticks, 90.7792 ns/op, 11015734.6 op/s
Target 1: 11000000 op, 1028.4 ms, 1028425652.1 ns, 2304706 ticks, 93.4932 ns/op, 10695960.4 op/s
Target 2: 11000000 op, 1023.2 ms, 1023237798.8 ns, 2293080 ticks, 93.0216 ns/op, 10750189.3 op/s
Target 3: 11000000 op, 986 ms, 985960310.6 ns, 2209541 ticks, 89.6328 ns/op, 11156635.7 op/s
Target 4: 11000000 op, 969.6 ms, 969603356.4 ns, 2172885 ticks, 88.1458 ns/op, 11344845.2 op/s
Target 5: 11000000 op, 968.4 ms, 968428882.8 ns, 2170253 ticks, 88.039 ns/op, 11358603.8 op/s
Target 6: 11000000 op, 966.4 ms, 966414607 ns, 2165739 ticks, 87.8559 ns/op, 11382278.3 op/s
Target 7: 11000000 op, 1013.5 ms, 1013490382 ns, 2271236 ticks, 92.1355 ns/op, 10853581 op/s
Target 8: 11000000 op, 1024.6 ms, 1024622892.2 ns, 2296184 ticks, 93.1475 ns/op, 10735657.1 op/s
Target 9: 11000000 op, 1044.6 ms, 1044552352.4 ns, 2340846 ticks, 94.9593 ns/op, 10530826.9 op/s
Target 10: 11000000 op, 1037.7 ms, 1037707652.5 ns, 2325507 ticks, 94.3371 ns/op, 10600288 op/s
// Benchmark finished

AverageTime (ns/op): Avr=93.1297730572727 +- 1.45229163878097
OperationsPerSecond: Avr=10756963.9892036 +- 163861.495273461

// **************************
// Benchmark: SimpleComparisonTest_ReflectionCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\SimpleComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 37483.2 ns, 84 ticks, 37483.1995 ns/op, 26678.6 op/s
// Pre-Warmup: 1000 op, 6.3 ms, 6270403.8 ns, 14052 ticks, 6270.4038 ns/op, 159479.4 op/s
// Pre-Warmup: 160000 op, 1028.7 ms, 1028667508 ns, 2305248 ticks, 6429.1719 ns/op, 155541 op/s
// Warmup (idle): 160000 op, 0.5 ms, 495313.7 ns, 1110 ticks, 3.0957 ns/op, 323027603.6 op/s
// Warmup (idle): 160000 op, 0.5 ms, 476125.9 ns, 1067 ticks, 2.9758 ns/op, 336045585.8 op/s
// Warmup (idle): 160000 op, 0.5 ms, 477018.3 ns, 1069 ticks, 2.9814 ns/op, 335416875.6 op/s
// IterationCount = 160000
// Target (idle): 160000 op, 0.5 ms, 482373.1 ns, 1081 ticks, 3.0148 ns/op, 331693469 op/s
// Target (idle): 160000 op, 0.5 ms, 478803.3 ns, 1073 ticks, 2.9925 ns/op, 334166486.5 op/s
// Target (idle): 160000 op, 0.5 ms, 481480.6 ns, 1079 ticks, 3.0093 ns/op, 332308285.4 op/s
// Target (idle): 160000 op, 0.5 ms, 481034.4 ns, 1078 ticks, 3.0065 ns/op, 332616549.2 op/s
// Target (idle): 160000 op, 0.5 ms, 479249.5 ns, 1074 ticks, 2.9953 ns/op, 333855344.5 op/s
// Warmup 1: 160000 op, 936.3 ms, 936344602.7 ns, 2098352 ticks, 5852.1538 ns/op, 170877.3 op/s
// Warmup 2: 160000 op, 952.9 ms, 952931364.7 ns, 2135523 ticks, 5955.821 ns/op, 167903 op/s
// Warmup 3: 160000 op, 952.1 ms, 952078621.9 ns, 2133612 ticks, 5950.4914 ns/op, 168053.3 op/s
// Warmup 4: 160000 op, 976 ms, 975991118.3 ns, 2187200 ticks, 6099.9445 ns/op, 163935.9 op/s
// Warmup 5: 160000 op, 1111.9 ms, 1111917694 ns, 2491812 ticks, 6949.4856 ns/op, 143895.5 op/s
Target 1: 160000 op, 1053.1 ms, 1053148499.5 ns, 2360110 ticks, 6582.1781 ns/op, 151925.4 op/s
Target 2: 160000 op, 1043.5 ms, 1043487651.1 ns, 2338460 ticks, 6521.7978 ns/op, 153332 op/s
Target 3: 160000 op, 1012.3 ms, 1012302521.5 ns, 2268574 ticks, 6326.8908 ns/op, 158055.5 op/s
Target 4: 160000 op, 940.5 ms, 940483818.9 ns, 2107628 ticks, 5878.0239 ns/op, 170125.2 op/s
Target 5: 160000 op, 928.5 ms, 928471792.1 ns, 2080709 ticks, 5802.9487 ns/op, 172326.2 op/s
Target 6: 160000 op, 927.1 ms, 927096961.9 ns, 2077628 ticks, 5794.356 ns/op, 172581.7 op/s
Target 7: 160000 op, 1006 ms, 1005989279.8 ns, 2254426 ticks, 6287.433 ns/op, 159047.4 op/s
Target 8: 160000 op, 944.9 ms, 944874707.9 ns, 2117468 ticks, 5905.4669 ns/op, 169334.6 op/s
Target 9: 160000 op, 1046.8 ms, 1046796435.9 ns, 2345875 ticks, 6542.4777 ns/op, 152847.3 op/s
Target 10: 160000 op, 1146.3 ms, 1146267030.3 ns, 2568789 ticks, 7164.1689 ns/op, 139583.5 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 20972.7 ns, 47 ticks, 20972.7426 ns/op, 47680.9 op/s
// Pre-Warmup: 1000 op, 7.7 ms, 7701458.8 ns, 17259 ticks, 7701.4588 ns/op, 129845.5 op/s
// Pre-Warmup: 130000 op, 846.4 ms, 846432224.1 ns, 1896858 ticks, 6511.0171 ns/op, 153585.8 op/s
// Pre-Warmup: 260000 op, 1698.1 ms, 1698114327.3 ns, 3805481 ticks, 6531.209 ns/op, 153111 op/s
// Warmup (idle): 260000 op, 0.8 ms, 779115.1 ns, 1746 ticks, 2.9966 ns/op, 333711935.9 op/s
// Warmup (idle): 260000 op, 0.8 ms, 775991.5 ns, 1739 ticks, 2.9846 ns/op, 335055227.1 op/s
// Warmup (idle): 260000 op, 0.8 ms, 775991.5 ns, 1739 ticks, 2.9846 ns/op, 335055227.1 op/s
// IterationCount = 260000
// Target (idle): 260000 op, 0.8 ms, 776883.9 ns, 1741 ticks, 2.988 ns/op, 334670327.4 op/s
// Target (idle): 260000 op, 0.8 ms, 808566.2 ns, 1812 ticks, 3.1099 ns/op, 321556865.3 op/s
// Target (idle): 260000 op, 0.8 ms, 775991.5 ns, 1739 ticks, 2.9846 ns/op, 335055227.1 op/s
// Target (idle): 260000 op, 0.8 ms, 775545.2 ns, 1738 ticks, 2.9829 ns/op, 335248009.2 op/s
// Target (idle): 260000 op, 0.8 ms, 797410.4 ns, 1787 ticks, 3.067 ns/op, 326055422.5 op/s
// Warmup 1: 260000 op, 1687.7 ms, 1687721664 ns, 3782191 ticks, 6491.2372 ns/op, 154053.8 op/s
// Warmup 2: 260000 op, 1564.1 ms, 1564106088.2 ns, 3505168 ticks, 6015.7926 ns/op, 166229.1 op/s
// Warmup 3: 260000 op, 1563.1 ms, 1563076638.9 ns, 3502861 ticks, 6011.8332 ns/op, 166338.6 op/s
// Warmup 4: 260000 op, 1533.7 ms, 1533702751.1 ns, 3437034 ticks, 5898.8567 ns/op, 169524.4 op/s
// Warmup 5: 260000 op, 1573 ms, 1572972203.5 ns, 3525037 ticks, 6049.8931 ns/op, 165292.2 op/s
Target 1: 260000 op, 1686.2 ms, 1686237507.8 ns, 3778865 ticks, 6485.5289 ns/op, 154189.4 op/s
Target 2: 260000 op, 1585 ms, 1584969504.7 ns, 3551923 ticks, 6096.0366 ns/op, 164041 op/s
Target 3: 260000 op, 1547.3 ms, 1547285502.4 ns, 3467473 ticks, 5951.0981 ns/op, 168036.2 op/s
Target 4: 260000 op, 1568.8 ms, 1568768730.4 ns, 3515617 ticks, 6033.7259 ns/op, 165735.1 op/s
Target 5: 260000 op, 1515.1 ms, 1515103052 ns, 3395352 ticks, 5827.3194 ns/op, 171605.5 op/s
Target 6: 260000 op, 1713.2 ms, 1713178557.5 ns, 3839240 ticks, 6589.1483 ns/op, 151764.7 op/s
Target 7: 260000 op, 1724.9 ms, 1724903213 ns, 3865515 ticks, 6634.2431 ns/op, 150733.1 op/s
Target 8: 260000 op, 1669.5 ms, 1669517323.5 ns, 3741395 ticks, 6421.2205 ns/op, 155733.6 op/s
Target 9: 260000 op, 1684.9 ms, 1684901499.5 ns, 3775871 ticks, 6480.3904 ns/op, 154311.7 op/s
Target 10: 260000 op, 1674.4 ms, 1674357564.7 ns, 3752242 ticks, 6439.8368 ns/op, 155283.4 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 16064.2 ns, 36 ticks, 16064.2284 ns/op, 62250.1 op/s
// Pre-Warmup: 1000 op, 6.6 ms, 6642558.4 ns, 14886 ticks, 6642.5584 ns/op, 150544.4 op/s
// Pre-Warmup: 151000 op, 974.4 ms, 974382464.3 ns, 2183595 ticks, 6452.864 ns/op, 154969.9 op/s
// Pre-Warmup: 302000 op, 1973.3 ms, 1973299021.3 ns, 4422171 ticks, 6534.1027 ns/op, 153043.2 op/s
// Warmup (idle): 302000 op, 0.9 ms, 920123.3 ns, 2062 ticks, 3.0468 ns/op, 328216880.7 op/s
// Warmup (idle): 302000 op, 1 ms, 975455.6 ns, 2186 ticks, 3.23 ns/op, 309598905.8 op/s
// Warmup (idle): 302000 op, 0.9 ms, 929494.1 ns, 2083 ticks, 3.0778 ns/op, 324907925.1 op/s
// IterationCount = 302000
// Target (idle): 302000 op, 0.9 ms, 922354.4 ns, 2067 ticks, 3.0542 ns/op, 327422935.7 op/s
// Target (idle): 302000 op, 0.9 ms, 910752.5 ns, 2041 ticks, 3.0157 ns/op, 331593928.5 op/s
// Target (idle): 302000 op, 0.9 ms, 944219.6 ns, 2116 ticks, 3.1266 ns/op, 319840835.5 op/s
// Target (idle): 302000 op, 1 ms, 985718.9 ns, 2209 ticks, 3.264 ns/op, 306375377.1 op/s
// Target (idle): 302000 op, 1 ms, 1014723.8 ns, 2274 ticks, 3.36 ns/op, 297617945.5 op/s
// Warmup 1: 302000 op, 1798.8 ms, 1798751363.2 ns, 4031009 ticks, 5956.1303 ns/op, 167894.2 op/s
// Warmup 2: 302000 op, 1768.9 ms, 1768916967.6 ns, 3964150 ticks, 5857.341 ns/op, 170725.9 op/s
// Warmup 3: 302000 op, 1750.6 ms, 1750633198.3 ns, 3923176 ticks, 5796.7987 ns/op, 172509 op/s
// Warmup 4: 302000 op, 2054.5 ms, 2054483615.4 ns, 4604106 ticks, 6802.9259 ns/op, 146995.6 op/s
// Warmup 5: 302000 op, 1936.6 ms, 1936559238.6 ns, 4339837 ticks, 6412.4478 ns/op, 155946.7 op/s
Target 1: 302000 op, 1991.6 ms, 1991607779.4 ns, 4463201 ticks, 6594.7277 ns/op, 151636.3 op/s
Target 2: 302000 op, 1939.8 ms, 1939810460 ns, 4347123 ticks, 6423.2134 ns/op, 155685.3 op/s
Target 3: 302000 op, 1905.6 ms, 1905645862.3 ns, 4270560 ticks, 6310.0856 ns/op, 158476.5 op/s
Target 4: 302000 op, 1933.5 ms, 1933495879.5 ns, 4332972 ticks, 6402.3042 ns/op, 156193.8 op/s
Target 5: 302000 op, 1966.2 ms, 1966172751.1 ns, 4406201 ticks, 6510.5058 ns/op, 153597.9 op/s
Target 6: 302000 op, 1956.8 ms, 1956807306 ns, 4385213 ticks, 6479.4944 ns/op, 154333 op/s
Target 7: 302000 op, 1995.9 ms, 1995862568.7 ns, 4472736 ticks, 6608.8165 ns/op, 151313 op/s
Target 8: 302000 op, 1982.7 ms, 1982718460.1 ns, 4443280 ticks, 6565.2929 ns/op, 152316.1 op/s
Target 9: 302000 op, 1939.8 ms, 1939842588.4 ns, 4347195 ticks, 6423.3198 ns/op, 155682.7 op/s
Target 10: 302000 op, 1977.9 ms, 1977945599.4 ns, 4432584 ticks, 6549.4887 ns/op, 152683.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=6354.38463207683 +- 112.565026829294
OperationsPerSecond: Avr=157750.363670324 +- 2838.21909069968

// ***** Competition: Finish  *****

```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=SimpleComparisonTest  Mode=Throughput  .NET=HostFramework  
```

             Method | Platform |       Jit |       AvrTime |      StdDev |          op/s |
------------------- |--------- |---------- |-------------- |------------ |-------------- |
 DynamicCodeCompare |      X64 | LegacyJit |   215.7626 ns |   8.2063 ns |  4,634,725.08 |
      ManualCompare |      X64 | LegacyJit |   160.4945 ns |   6.8949 ns |  6,230,741.94 |
  ReflectionCompare |      X64 | LegacyJit | 6,654.3290 ns | 380.7790 ns |    150,278.15 |
 DynamicCodeCompare |      X64 |    RyuJit |   168.4194 ns |   9.4654 ns |  5,937,569.56 |
      ManualCompare |      X64 |    RyuJit |    87.8513 ns |   3.3118 ns | 11,382,874.20 |
  ReflectionCompare |      X64 |    RyuJit | 6,954.6437 ns | 387.1803 ns |    143,789.85 |
 DynamicCodeCompare |      X86 | LegacyJit |   180.4105 ns |   6.5036 ns |  5,542,914.59 |
      ManualCompare |      X86 | LegacyJit |    93.0846 ns |   4.0584 ns | 10,742,923.17 |
  ReflectionCompare |      X86 | LegacyJit | 6,431.5783 ns | 314.5633 ns |    155,483.09 |

// ***** Competition: End *****
```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=SimpleComparisonTest  Mode=Throughput  .NET=HostFramework  
```

             Method | Platform |       Jit |       AvrTime |      StdDev |          op/s |
------------------- |--------- |---------- |-------------- |------------ |-------------- |
 DynamicCodeCompare |      X64 | LegacyJit |   215.7626 ns |   8.2063 ns |  4,634,725.08 |
      ManualCompare |      X64 | LegacyJit |   160.4945 ns |   6.8949 ns |  6,230,741.94 |
  ReflectionCompare |      X64 | LegacyJit | 6,654.3290 ns | 380.7790 ns |    150,278.15 |
 DynamicCodeCompare |      X64 |    RyuJit |   168.4194 ns |   9.4654 ns |  5,937,569.56 |
      ManualCompare |