// ***** Competition: Start   *****
// Found benchmarks:
//   SimpleComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10
//   SimpleComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10

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
// Pre-Warmup: 1 op, 0 ms, 7139.7 ns, 16 ticks, 7139.6539 ns/op, 140062.8 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 240517.1 ns, 539 ticks, 240.5171 ns/op, 4157708.7 op/s
// Pre-Warmup: 1000000 op, 150.7 ms, 150735049.7 ns, 337798 ticks, 150.735 ns/op, 6634157.1 op/s
// Pre-Warmup: 7000000 op, 944.3 ms, 944337027.4 ns, 2116264 ticks, 134.9053 ns/op, 7412607.8 op/s
// Pre-Warmup: 14000000 op, 1800.9 ms, 1800935294.7 ns, 4035905 ticks, 128.6382 ns/op, 7773738.5 op/s
// Warmup (idle): 14000000 op, 41.3 ms, 41340380.8 ns, 92644 ticks, 2.9529 ns/op, 338651936.4 op/s
// Warmup (idle): 14000000 op, 41 ms, 40958855.5 ns, 91789 ticks, 2.9256 ns/op, 341806425.6 op/s
// Warmup (idle): 14000000 op, 40.8 ms, 40792858.6 ns, 91417 ticks, 2.9138 ns/op, 343197326.5 op/s
// IterationCount = 14000000
// Target (idle): 14000000 op, 41.3 ms, 41329671.3 ns, 92620 ticks, 2.9521 ns/op, 338739689.1 op/s
// Target (idle): 14000000 op, 40.7 ms, 40654081.5 ns, 91106 ticks, 2.9039 ns/op, 344368867 op/s
// Target (idle): 14000000 op, 40.8 ms, 40842836.1 ns, 91529 ticks, 2.9173 ns/op, 342777371.1 op/s
// Target (idle): 14000000 op, 41.4 ms, 41432303.8 ns, 92850 ticks, 2.9595 ns/op, 337900592.4 op/s
// Target (idle): 14000000 op, 40.9 ms, 40891028.8 ns, 91637 ticks, 2.9208 ns/op, 342373386.3 op/s
// Warmup 1: 14000000 op, 1713.6 ms, 1713602602.4 ns, 3840192 ticks, 122.4002 ns/op, 8169922.2 op/s
// Warmup 2: 14000000 op, 1718.6 ms, 1718603037.5 ns, 3851398 ticks, 122.7574 ns/op, 8146151.1 op/s
// Warmup 3: 14000000 op, 1852.9 ms, 1852912421 ns, 4152386 ticks, 132.3509 ns/op, 7555672.8 op/s
// Warmup 4: 14000000 op, 1845 ms, 1845032920.5 ns, 4134728 ticks, 131.7881 ns/op, 7587940.5 op/s
// Warmup 5: 14000000 op, 1869.1 ms, 1869129698.5 ns, 4188729 ticks, 133.5093 ns/op, 7490116.9 op/s
Target 1: 14000000 op, 1840.9 ms, 1840878980.6 ns, 4125419 ticks, 131.4914 ns/op, 7605062.7 op/s
Target 2: 14000000 op, 1721.2 ms, 1721190269.5 ns, 3857196 ticks, 122.9422 ns/op, 8133906.1 op/s
Target 3: 14000000 op, 1698.8 ms, 1698828427.4 ns, 3807083 ticks, 121.3449 ns/op, 8240973.5 op/s
Target 4: 14000000 op, 1714.6 ms, 1714616433.3 ns, 3842464 ticks, 122.4726 ns/op, 8165091.5 op/s
Target 5: 14000000 op, 1872.6 ms, 1872626790.2 ns, 4196566 ticks, 133.7591 ns/op, 7476129.3 op/s
Target 6: 14000000 op, 1845.8 ms, 1845794632.3 ns, 4136435 ticks, 131.8425 ns/op, 7584809.1 op/s
Target 7: 14000000 op, 1836.3 ms, 1836287290.7 ns, 4115129 ticks, 131.1634 ns/op, 7624079.3 op/s
Target 8: 14000000 op, 1869.9 ms, 1869879808.4 ns, 4190410 ticks, 133.5628 ns/op, 7487112.2 op/s
Target 9: 14000000 op, 1855.6 ms, 1855581312.8 ns, 4158367 ticks, 132.5415 ns/op, 7544805.4 op/s
Target 10: 14000000 op, 1842.5 ms, 1842547874.7 ns, 4129159 ticks, 131.6106 ns/op, 7598174.3 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 4016.1 ns, 9 ticks, 4016.0553 ns/op, 249000.6 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 149932.7 ns, 336 ticks, 149.9327 ns/op, 6669657.7 op/s
// Pre-Warmup: 1000000 op, 139.8 ms, 139761401.7 ns, 313206 ticks, 139.7614 ns/op, 7155051.3 op/s
// Pre-Warmup: 8000000 op, 1094.1 ms, 1094149723 ns, 2451995 ticks, 136.7687 ns/op, 7311613.6 op/s
// Warmup (idle): 8000000 op, 23.1 ms, 23127570 ns, 51829 ticks, 2.8909 ns/op, 345907503.5 op/s
// Warmup (idle): 8000000 op, 23.8 ms, 23837519.3 ns, 53420 ticks, 2.9797 ns/op, 335605391.2 op/s
// Warmup (idle): 8000000 op, 23.1 ms, 23089194.4 ns, 51743 ticks, 2.8861 ns/op, 346482422.7 op/s
// IterationCount = 8000000
// Target (idle): 8000000 op, 24 ms, 24030290 ns, 53852 ticks, 3.0038 ns/op, 332913169.4 op/s
// Target (idle): 8000000 op, 22.9 ms, 22944616.4 ns, 51419 ticks, 2.8681 ns/op, 348665668.3 op/s
// Target (idle): 8000000 op, 24.3 ms, 24292226 ns, 54439 ticks, 3.0365 ns/op, 329323463 op/s
// Target (idle): 8000000 op, 25.1 ms, 25074910.6 ns, 56193 ticks, 3.1344 ns/op, 319044009 op/s
// Target (idle): 8000000 op, 24.6 ms, 24584505.6 ns, 55094 ticks, 3.0731 ns/op, 325408211.4 op/s
// Warmup 1: 8000000 op, 1047.7 ms, 1047660313.1 ns, 2347812 ticks, 130.9575 ns/op, 7636062.9 op/s
// Warmup 2: 8000000 op, 1113.3 ms, 1113261683.9 ns, 2494825 ticks, 139.1577 ns/op, 7186091.2 op/s
// Warmup 3: 8000000 op, 1049.8 ms, 1049837015.1 ns, 2352690 ticks, 131.2296 ns/op, 7620230.5 op/s
// Warmup 4: 8000000 op, 1069.9 ms, 1069943619 ns, 2397749 ticks, 133.743 ns/op, 7477029.5 op/s
// Warmup 5: 8000000 op, 1062.9 ms, 1062911952.4 ns, 2381991 ticks, 132.864 ns/op, 7526493.6 op/s
Target 1: 8000000 op, 1045.3 ms, 1045253803.5 ns, 2342419 ticks, 130.6567 ns/op, 7653643.5 op/s
Target 2: 8000000 op, 1075 ms, 1075011880.8 ns, 2409107 ticks, 134.3765 ns/op, 7441778.2 op/s
Target 3: 8000000 op, 1075.7 ms, 1075728523.6 ns, 2410713 ticks, 134.4661 ns/op, 7436820.6 op/s
Target 4: 8000000 op, 1084.3 ms, 1084276920.4 ns, 2429870 ticks, 135.5346 ns/op, 7378189 op/s
Target 5: 8000000 op, 994.2 ms, 994207509.6 ns, 2228024 ticks, 124.2759 ns/op, 8046609.9 op/s
Target 6: 8000000 op, 984.3 ms, 984319089 ns, 2205864 ticks, 123.0399 ns/op, 8127445.8 op/s
Target 7: 8000000 op, 975.4 ms, 975432897.3 ns, 2185950 ticks, 121.9291 ns/op, 8201486.8 op/s
Target 8: 8000000 op, 968.6 ms, 968570797.5 ns, 2170572 ticks, 121.0713 ns/op, 8259592.4 op/s
Target 9: 8000000 op, 993.9 ms, 993931294.2 ns, 2227405 ticks, 124.2414 ns/op, 8048846.1 op/s
Target 10: 8000000 op, 1067.3 ms, 1067340322.8 ns, 2391915 ticks, 133.4175 ns/op, 7495266.3 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 6693.4 ns, 15 ticks, 6693.4255 ns/op, 149400.3 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 147255.4 ns, 330 ticks, 147.2554 ns/op, 6790924.2 op/s
// Pre-Warmup: 1000000 op, 146.9 ms, 146893915.9 ns, 329190 ticks, 146.8939 ns/op, 6807633.9 op/s
// Pre-Warmup: 7000000 op, 935.5 ms, 935534726.6 ns, 2096538 ticks, 133.6478 ns/op, 7482351.9 op/s
// Pre-Warmup: 14000000 op, 1880.4 ms, 1880367959.9 ns, 4213914 ticks, 134.312 ns/op, 7445351.3 op/s
// Warmup (idle): 14000000 op, 41.6 ms, 41561710 ns, 93140 ticks, 2.9687 ns/op, 336848507.6 op/s
// Warmup (idle): 14000000 op, 42.5 ms, 42488526.4 ns, 95217 ticks, 3.0349 ns/op, 329500719.4 op/s
// Warmup (idle): 14000000 op, 41.2 ms, 41152964.9 ns, 92224 ticks, 2.9395 ns/op, 340194201.1 op/s
// IterationCount = 14000000
// Target (idle): 14000000 op, 41 ms, 40969118.8 ns, 91812 ticks, 2.9264 ns/op, 341720799 op/s
// Target (idle): 14000000 op, 41.3 ms, 41302451.4 ns, 92559 ticks, 2.9502 ns/op, 338962931.8 op/s
// Target (idle): 14000000 op, 41.8 ms, 41833909.3 ns, 93750 ticks, 2.9881 ns/op, 334656746.7 op/s
// Target (idle): 14000000 op, 43.5 ms, 43478707.1 ns, 97436 ticks, 3.1056 ns/op, 321996695.3 op/s
// Target (idle): 14000000 op, 42.6 ms, 42579556.9 ns, 95421 ticks, 3.0414 ns/op, 328796281.7 op/s
// Warmup 1: 14000000 op, 1843.3 ms, 1843313156.4 ns, 4130874 ticks, 131.6652 ns/op, 7595019.8 op/s
// Warmup 2: 14000000 op, 1826.1 ms, 1826127563.3 ns, 4092361 ticks, 130.4377 ns/op, 7666496.2 op/s
// Warmup 3: 14000000 op, 1851.4 ms, 1851376056.7 ns, 4148943 ticks, 132.2411 ns/op, 7561942.9 op/s
// Warmup 4: 14000000 op, 1868.6 ms, 1868621444.4 ns, 4187590 ticks, 133.473 ns/op, 7492154.2 op/s
// Warmup 5: 14000000 op, 1725.7 ms, 1725729304.5 ns, 3867368 ticks, 123.2664 ns/op, 8112512.2 op/s
Target 1: 14000000 op, 1690.1 ms, 1690127866.7 ns, 3787585 ticks, 120.7234 ns/op, 8283396.9 op/s
Target 2: 14000000 op, 1820.8 ms, 1820756312.5 ns, 4080324 ticks, 130.054 ns/op, 7689112.4 op/s
Target 3: 14000000 op, 1847.1 ms, 1847111898.5 ns, 4139387 ticks, 131.9366 ns/op, 7579400 op/s
Target 4: 14000000 op, 1817.4 ms, 1817448867.8 ns, 4072912 ticks, 129.8178 ns/op, 7703105.3 op/s
Target 5: 14000000 op, 1736.4 ms, 1736389253.9 ns, 3891257 ticks, 124.0278 ns/op, 8062708.3 op/s
Target 6: 14000000 op, 1868.9 ms, 1868940943.9 ns, 4188306 ticks, 133.4958 ns/op, 7490873.4 op/s
Target 7: 14000000 op, 1857.6 ms, 1857593356.6 ns, 4162876 ticks, 132.6852 ns/op, 7536633.3 op/s
Target 8: 14000000 op, 1847.8 ms, 1847764284.3 ns, 4140849 ticks, 131.9832 ns/op, 7576724 op/s
Target 9: 14000000 op, 1846.7 ms, 1846722787.3 ns, 4138515 ticks, 131.9088 ns/op, 7580997 op/s
Target 10: 14000000 op, 1841.7 ms, 1841695578.5 ns, 4127249 ticks, 131.5497 ns/op, 7601690.6 op/s
// Benchmark finished

AverageTime (ns/op): Avr=129.130739970536 +- 1.75503613368238
OperationsPerSecond: Avr=7755148.77925889 +- 107819.571481718

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
// Pre-Warmup: 1 op, 0.1 ms, 62025.7 ns, 139 ticks, 62025.7429 ns/op, 16122.3 op/s
// Pre-Warmup: 1000 op, 8.9 ms, 8852724.6 ns, 19839 ticks, 8852.7246 ns/op, 112959.6 op/s
// Pre-Warmup: 113000 op, 437 ms, 437006164.6 ns, 979333 ticks, 3867.3112 ns/op, 258577.6 op/s
// Pre-Warmup: 339000 op, 1253.1 ms, 1253147583.3 ns, 2808310 ticks, 3696.6005 ns/op, 270518.8 op/s
// Warmup (idle): 339000 op, 1.1 ms, 1090135.9 ns, 2443 ticks, 3.2157 ns/op, 310970403.2 op/s
// Warmup (idle): 339000 op, 1.1 ms, 1060684.8 ns, 2377 ticks, 3.1289 ns/op, 319604835.9 op/s
// Warmup (idle): 339000 op, 1.1 ms, 1085673.6 ns, 2433 ticks, 3.2026 ns/op, 312248538.8 op/s
// IterationCount = 339000
// Target (idle): 339000 op, 1.1 ms, 1053098.9 ns, 2360 ticks, 3.1065 ns/op, 321907074.2 op/s
// Target (idle): 339000 op, 1.1 ms, 1074517.9 ns, 2408 ticks, 3.1697 ns/op, 315490321.8 op/s
// Target (idle): 339000 op, 1.1 ms, 1078087.7 ns, 2416 ticks, 3.1802 ns/op, 314445651.9 op/s
// Target (idle): 339000 op, 1 ms, 1024986.6 ns, 2297 ticks, 3.0236 ns/op, 330736044.8 op/s
// Target (idle): 339000 op, 1.1 ms, 1116017.1 ns, 2501 ticks, 3.2921 ns/op, 303758774.5 op/s
// Warmup 1: 339000 op, 1167.6 ms, 1167632825.5 ns, 2616671 ticks, 3444.3446 ns/op, 290331 op/s
// Warmup 2: 339000 op, 1201.7 ms, 1201665770.5 ns, 2692939 ticks, 3544.7368 ns/op, 282108.4 op/s
// Warmup 3: 339000 op, 1188.8 ms, 1188800560.5 ns, 2664108 ticks, 3506.7863 ns/op, 285161.4 op/s
// Warmup 4: 339000 op, 1219.3 ms, 1219270818.2 ns, 2732392 ticks, 3596.6691 ns/op, 278035 op/s
// Warmup 5: 339000 op, 1369.6 ms, 1369589090.6 ns, 3069256 ticks, 4040.0858 ns/op, 247519.5 op/s
Target 1: 339000 op, 1366.3 ms, 1366343225.5 ns, 3061982 ticks, 4030.511 ns/op, 248107.5 op/s
Target 2: 339000 op, 1427.7 ms, 1427668836.1 ns, 3199413 ticks, 4211.4125 ns/op, 237450 op/s
Target 3: 339000 op, 1312.1 ms, 1312134957.3 ns, 2940501 ticks, 3870.6046 ns/op, 258357.6 op/s
Target 4: 339000 op, 1186.5 ms, 1186481065.4 ns, 2658910 ticks, 3499.9441 ns/op, 285718.8 op/s
Target 5: 339000 op, 1231 ms, 1230954415.5 ns, 2758575 ticks, 3631.134 ns/op, 275396.1 op/s
Target 6: 339000 op, 1201.6 ms, 1201550643.6 ns, 2692681 ticks, 3544.3972 ns/op, 282135.4 op/s
Target 7: 339000 op, 1310 ms, 1309950223.2 ns, 2935605 ticks, 3864.16 ns/op, 258788.5 op/s
Target 8: 339000 op, 1234.4 ms, 1234365831.4 ns, 2766220 ticks, 3641.1971 ns/op, 274635 op/s
Target 9: 339000 op, 1189.5 ms, 1189460978.4 ns, 2665588 ticks, 3508.7344 ns/op, 285003 op/s
Target 10: 339000 op, 1187.7 ms, 1187683204.6 ns, 2661604 ticks, 3503.4903 ns/op, 285429.6 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 46854 ns, 105 ticks, 46853.9785 ns/op, 21342.9 op/s
// Pre-Warmup: 1000 op, 3.7 ms, 3682722.7 ns, 8253 ticks, 3682.7227 ns/op, 271538.2 op/s
// Pre-Warmup: 272000 op, 1087.6 ms, 1087570532 ns, 2437251 ticks, 3998.4211 ns/op, 250098.7 op/s
// Warmup (idle): 272000 op, 0.8 ms, 817490.4 ns, 1832 ticks, 3.0055 ns/op, 332725633.2 op/s
// Warmup (idle): 272000 op, 0.8 ms, 803211.1 ns, 1800 ticks, 2.953 ns/op, 338640755.6 op/s
// Warmup (idle): 272000 op, 0.8 ms, 793394 ns, 1778 ticks, 2.9169 ns/op, 342830911.1 op/s
// IterationCount = 272000
// Target (idle): 272000 op, 0.8 ms, 826861.2 ns, 1853 ticks, 3.0399 ns/op, 328954862.4 op/s
// Target (idle): 272000 op, 0.9 ms, 860774.5 ns, 1929 ticks, 3.1646 ns/op, 315994484.2 op/s
// Target (idle): 272000 op, 0.8 ms, 803657.3 ns, 1801 ticks, 2.9546 ns/op, 338452726.3 op/s
// Target (idle): 272000 op, 0.8 ms, 819275.3 ns, 1836 ticks, 3.012 ns/op, 332000740.7 op/s
// Target (idle): 272000 op, 0.8 ms, 833108.4 ns, 1867 ticks, 3.0629 ns/op, 326488141.4 op/s
// Warmup 1: 272000 op, 994.1 ms, 994054453.2 ns, 2227681 ticks, 3654.612 ns/op, 273626.9 op/s
// Warmup 2: 272000 op, 951.3 ms, 951317823.9 ns, 2131908 ticks, 3497.492 ns/op, 285919.2 op/s
// Warmup 3: 272000 op, 948 ms, 948038045.4 ns, 2124558 ticks, 3485.434 ns/op, 286908.3 op/s
// Warmup 4: 272000 op, 944.8 ms, 944818507.8 ns, 2117343 ticks, 3473.5975 ns/op, 287886 op/s
// Warmup 5: 272000 op, 951.2 ms, 951237949 ns, 2131729 ticks, 3497.1983 ns/op, 285943.2 op/s
Target 1: 272000 op, 1019.4 ms, 1019378359.3 ns, 2284432 ticks, 3747.7146 ns/op, 266829.3 op/s
Target 2: 272000 op, 1068 ms, 1067959687.7 ns, 2393303 ticks, 3926.3224 ns/op, 254691.3 op/s
Target 3: 272000 op, 1061.6 ms, 1061648233.7 ns, 2379159 ticks, 3903.1185 ns/op, 256205.4 op/s
Target 4: 272000 op, 1060.4 ms, 1060370681.9 ns, 2376296 ticks, 3898.4216 ns/op, 256514.1 op/s
Target 5: 272000 op, 1048.6 ms, 1048630859.8 ns, 2349987 ticks, 3855.2605 ns/op, 259385.8 op/s
Target 6: 272000 op, 1074.1 ms, 1074139504.4 ns, 2407152 ticks, 3949.0423 ns/op, 253226 op/s
Target 7: 272000 op, 1105.8 ms, 1105828411.8 ns, 2478167 ticks, 4065.5456 ns/op, 245969.4 op/s
Target 8: 272000 op, 1246.7 ms, 1246700475.9 ns, 2793862 ticks, 4583.4576 ns/op, 218175.9 op/s
Target 9: 272000 op, 1075.3 ms, 1075256860.2 ns, 2409656 ticks, 3953.1502 ns/op, 252962.8 op/s
Target 10: 272000 op, 1125.8 ms, 1125834168.2 ns, 2523000 ticks, 4139.0962 ns/op, 241598.6 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 27219.9 ns, 61 ticks, 27219.9303 ns/op, 36737.8 op/s
// Pre-Warmup: 1000 op, 3.6 ms, 3622481.9 ns, 8118 ticks, 3622.4819 ns/op, 276053.8 op/s
// Pre-Warmup: 277000 op, 1082 ms, 1082039085.1 ns, 2424855 ticks, 3906.2783 ns/op, 255998.1 op/s
// Warmup (idle): 277000 op, 0.8 ms, 808565.8 ns, 1812 ticks, 2.919 ns/op, 342581890.2 op/s
// Warmup (idle): 277000 op, 0.8 ms, 816597.9 ns, 1830 ticks, 2.948 ns/op, 339212232.2 op/s
// Warmup (idle): 277000 op, 0.8 ms, 849618.8 ns, 1904 ticks, 3.0672 ns/op, 326028563.6 op/s
// IterationCount = 277000
// Target (idle): 277000 op, 0.9 ms, 860328.3 ns, 1928 ticks, 3.1059 ns/op, 321970116.7 op/s
// Target (idle): 277000 op, 0.9 ms, 863898.1 ns, 1936 ticks, 3.1188 ns/op, 320639661.7 op/s
// Target (idle): 277000 op, 0.9 ms, 858543.4 ns, 1924 ticks, 3.0994 ns/op, 322639493.2 op/s
// Target (idle): 277000 op, 0.8 ms, 802318.6 ns, 1798 ticks, 2.8965 ns/op, 345249379.9 op/s
// Target (idle): 277000 op, 0.8 ms, 802318.6 ns, 1798 ticks, 2.8965 ns/op, 345249379.9 op/s
// Warmup 1: 277000 op, 1082.5 ms, 1082455416.2 ns, 2425788 ticks, 3907.7813 ns/op, 255899.7 op/s
// Warmup 2: 277000 op, 1071.9 ms, 1071879357.7 ns, 2402087 ticks, 3869.6006 ns/op, 258424.6 op/s
// Warmup 3: 277000 op, 1075.7 ms, 1075731647.2 ns, 2410720 ticks, 3883.5078 ns/op, 257499.2 op/s
// Warmup 4: 277000 op, 1020.5 ms, 1020470726.3 ns, 2286880 ticks, 3684.0098 ns/op, 271443.4 op/s
// Warmup 5: 277000 op, 949.1 ms, 949068833 ns, 2126868 ticks, 3426.2413 ns/op, 291865 op/s
Target 1: 277000 op, 970.3 ms, 970258879.4 ns, 2174355 ticks, 3502.7396 ns/op, 285490.8 op/s
Target 2: 277000 op, 949.9 ms, 949867581.7 ns, 2128658 ticks, 3429.1248 ns/op, 291619.6 op/s
Target 3: 277000 op, 960 ms, 960006336.4 ns, 2151379 ticks, 3465.7268 ns/op, 288539.8 op/s
Target 4: 277000 op, 1006.6 ms, 1006578744.8 ns, 2255748 ticks, 3633.8583 ns/op, 275189.6 op/s
Target 5: 277000 op, 1173.8 ms, 1173840754.5 ns, 2630583 ticks, 4237.6923 ns/op, 235977.5 op/s
Target 6: 277000 op, 1101.6 ms, 1101585672.5 ns, 2468659 ticks, 3976.8436 ns/op, 251455.7 op/s
Target 7: 277000 op, 1063.3 ms, 1063280090.9 ns, 2382816 ticks, 3838.5563 ns/op, 260514.6 op/s
Target 8: 277000 op, 1073.7 ms, 1073730759.2 ns, 2406236 ticks, 3876.2843 ns/op, 257979 op/s
Target 9: 277000 op, 1053.1 ms, 1053064138.6 ns, 2359922 ticks, 3801.6756 ns/op, 263041.9 op/s
Target 10: 277000 op, 1002.2 ms, 1002161084 ns, 2245848 ticks, 3617.9101 ns/op, 276402.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=3823.57088227156 +- 96.5769149518625
OperationsPerSecond: Avr=262759.710064152 +- 6445.85454619368

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
// Pre-Warmup: 1 op, 0 ms, 8924.6 ns, 20 ticks, 8924.5673 ns/op, 112050.3 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 94154.2 ns, 211 ticks, 94.1542 ns/op, 10620876.8 op/s
// Pre-Warmup: 1000000 op, 69.6 ms, 69609394 ns, 155995 ticks, 69.6094 ns/op, 14365877.1 op/s
// Pre-Warmup: 15000000 op, 979.1 ms, 979068319.8 ns, 2194097 ticks, 65.2712 ns/op, 15320687.7 op/s
// Pre-Warmup: 30000000 op, 1963.1 ms, 1963072817.8 ns, 4399256 ticks, 65.4358 ns/op, 15282163.6 op/s
// Warmup (idle): 30000000 op, 91.8 ms, 91825765.7 ns, 205782 ticks, 3.0609 ns/op, 326705688.5 op/s
// Warmup (idle): 30000000 op, 87.6 ms, 87553129.1 ns, 196207 ticks, 2.9184 ns/op, 342649090 op/s
// Warmup (idle): 30000000 op, 92.9 ms, 92852090.9 ns, 208082 ticks, 3.0951 ns/op, 323094501.2 op/s
// IterationCount = 30000000
// Target (idle): 30000000 op, 96.3 ms, 96307237.2 ns, 215825 ticks, 3.2102 ns/op, 311503069.6 op/s
// Target (idle): 30000000 op, 92 ms, 91953833.2 ns, 206069 ticks, 3.0651 ns/op, 326250673.3 op/s
// Target (idle): 30000000 op, 87.8 ms, 87768657.4 ns, 196690 ticks, 2.9256 ns/op, 341807666.9 op/s
// Target (idle): 30000000 op, 89.7 ms, 89717782.9 ns, 201058 ticks, 2.9906 ns/op, 334381869.9 op/s
// Target (idle): 30000000 op, 91.8 ms, 91750799.3 ns, 205614 ticks, 3.0584 ns/op, 326972628.3 op/s
// Warmup 1: 30000000 op, 1774 ms, 1774016568.5 ns, 3975580 ticks, 59.1339 ns/op, 16910777.8 op/s
// Warmup 2: 30000000 op, 1747 ms, 1746965758.7 ns, 3914959 ticks, 58.2322 ns/op, 17172631.9 op/s
// Warmup 3: 30000000 op, 1810.2 ms, 1810202565.4 ns, 4056673 ticks, 60.3401 ns/op, 16572730.9 op/s
// Warmup 4: 30000000 op, 1890.4 ms, 1890359013 ns, 4236304 ticks, 63.012 ns/op, 15870001.3 op/s
// Warmup 5: 30000000 op, 1872.7 ms, 1872694616.9 ns, 4196718 ticks, 62.4232 ns/op, 16019696.8 op/s
Target 1: 30000000 op, 1861.4 ms, 1861380050.5 ns, 4171362 ticks, 62.046 ns/op, 16117074 op/s
Target 2: 30000000 op, 1804.2 ms, 1804172235.2 ns, 4043159 ticks, 60.1391 ns/op, 16628124.2 op/s
Target 3: 30000000 op, 1759.8 ms, 1759812227.1 ns, 3943748 ticks, 58.6604 ns/op, 17047273.3 op/s
Target 4: 30000000 op, 1761 ms, 1761028645.6 ns, 3946474 ticks, 58.701 ns/op, 17035498 op/s
Target 5: 30000000 op, 1746.4 ms, 1746377629.7 ns, 3913641 ticks, 58.2126 ns/op, 17178415.2 op/s
Target 6: 30000000 op, 1757.2 ms, 1757245967.8 ns, 3937997 ticks, 58.5749 ns/op, 17072168.9 op/s
Target 7: 30000000 op, 1840.4 ms, 1840394822.9 ns, 4124334 ticks, 61.3465 ns/op, 16300850 op/s
Target 8: 30000000 op, 1869.6 ms, 1869571464.6 ns, 4189719 ticks, 62.319 ns/op, 16046458 op/s
Target 9: 30000000 op, 1865.4 ms, 1865355499 ns, 4180271 ticks, 62.1785 ns/op, 16082725.3 op/s
Target 10: 30000000 op, 1866.8 ms, 1866753978.7 ns, 4183405 ticks, 62.2251 ns/op, 16070676.9 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 3569.8 ns, 8 ticks, 3569.8269 ns/op, 280125.6 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 74073.9 ns, 166 ticks, 74.0739 ns/op, 13500030.1 op/s
// Pre-Warmup: 1000000 op, 76.4 ms, 76441596.5 ns, 171306 ticks, 76.4416 ns/op, 13081882.7 op/s
// Pre-Warmup: 14000000 op, 902.4 ms, 902416103.5 ns, 2022319 ticks, 64.4583 ns/op, 15513907.5 op/s
// Pre-Warmup: 28000000 op, 1720.1 ms, 1720105934.6 ns, 3854766 ticks, 61.4324 ns/op, 16278067.2 op/s
// Warmup (idle): 28000000 op, 82 ms, 82001602 ns, 183766 ticks, 2.9286 ns/op, 341456743.9 op/s
// Warmup (idle): 28000000 op, 82.1 ms, 82060950.3 ns, 183899 ticks, 2.9307 ns/op, 341209794.5 op/s
// Warmup (idle): 28000000 op, 83 ms, 83036851.8 ns, 186086 ticks, 2.9656 ns/op, 337199681.9 op/s
// IterationCount = 28000000
// Target (idle): 28000000 op, 82 ms, 81958317.8 ns, 183669 ticks, 2.9271 ns/op, 341637075.4 op/s
// Target (idle): 28000000 op, 81.2 ms, 81243906.2 ns, 182068 ticks, 2.9016 ns/op, 344641232.9 op/s
// Target (idle): 28000000 op, 81.4 ms, 81356355.7 ns, 182320 ticks, 2.9056 ns/op, 344164874.9 op/s
// Target (idle): 28000000 op, 82 ms, 82038638.9 ns, 183849 ticks, 2.93 ns/op, 341302590.7 op/s
// Target (idle): 28000000 op, 81.1 ms, 81067646 ns, 181673 ticks, 2.8953 ns/op, 345390564.4 op/s
// Warmup 1: 28000000 op, 1670.4 ms, 1670375121.9 ns, 3743319 ticks, 59.6563 ns/op, 16762701.8 op/s
// Warmup 2: 28000000 op, 1730.1 ms, 1730057273.4 ns, 3877067 ticks, 61.7878 ns/op, 16184435.3 op/s
// Warmup 3: 28000000 op, 1756.7 ms, 1756695322 ns, 3936763 ticks, 62.7391 ns/op, 15939018.9 op/s
// Warmup 4: 28000000 op, 1750.1 ms, 1750105421.5 ns, 3921995 ticks, 62.5038 ns/op, 15999036.2 op/s
// Warmup 5: 28000000 op, 1752.3 ms, 1752289263.1 ns, 3926889 ticks, 62.5818 ns/op, 15979096.9 op/s
Target 1: 28000000 op, 1733.7 ms, 1733696712 ns, 3885223 ticks, 61.9177 ns/op, 16150460.3 op/s
Target 2: 28000000 op, 1745.4 ms, 1745369153.6 ns, 3911381 ticks, 62.3346 ns/op, 16042451.5 op/s
Target 3: 28000000 op, 1765.9 ms, 1765907260.4 ns, 3957407 ticks, 63.0681 ns/op, 15855872.3 op/s
Target 4: 28000000 op, 1801.1 ms, 1801085227.4 ns, 4036241 ticks, 64.3245 ns/op, 15546182.7 op/s
Target 5: 28000000 op, 1760.1 ms, 1760093351 ns, 3944378 ticks, 62.8605 ns/op, 15908247.1 op/s
Target 6: 28000000 op, 1699.4 ms, 1699443776.3 ns, 3808462 ticks, 60.6944 ns/op, 16475979 op/s
Target 7: 28000000 op, 1741.1 ms, 1741108565.1 ns, 3901833 ticks, 62.1824 ns/op, 16081708.3 op/s
Target 8: 28000000 op, 1754.1 ms, 1754139772.1 ns, 3931036 ticks, 62.6478 ns/op, 15962240 op/s
Target 9: 28000000 op, 1744.7 ms, 1744692225.1 ns, 3909864 ticks, 62.3104 ns/op, 16048675.9 op/s
Target 10: 28000000 op, 1762.7 ms, 1762664965 ns, 3950141 ticks, 62.9523 ns/op, 15885038 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 7585.9 ns, 17 ticks, 7585.8822 ns/op, 131823.8 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 128513.8 ns, 288 ticks, 128.5138 ns/op, 7781267.4 op/s
// Pre-Warmup: 1000000 op, 73.6 ms, 73597336.9 ns, 164932 ticks, 73.5973 ns/op, 13587448.2 op/s
// Pre-Warmup: 14000000 op, 914 ms, 914049277 ns, 2048389 ticks, 65.2892 ns/op, 15316460.9 op/s
// Pre-Warmup: 28000000 op, 1710.5 ms, 1710470079.3 ns, 3833172 ticks, 61.0882 ns/op, 16369769 op/s
// Warmup (idle): 28000000 op, 81.8 ms, 81840067.3 ns, 183404 ticks, 2.9229 ns/op, 342130706 op/s
// Warmup (idle): 28000000 op, 82.4 ms, 82360369.6 ns, 184570 ticks, 2.9414 ns/op, 339969334.1 op/s
// Warmup (idle): 28000000 op, 82.8 ms, 82794996 ns, 185544 ticks, 2.957 ns/op, 338184689.3 op/s
// IterationCount = 28000000
// Target (idle): 28000000 op, 82.1 ms, 82088170.3 ns, 183960 ticks, 2.9317 ns/op, 341096651.4 op/s
// Target (idle): 28000000 op, 81.4 ms, 81399639.9 ns, 182417 ticks, 2.9071 ns/op, 343981865.7 op/s
// Target (idle): 28000000 op, 81.3 ms, 81300131 ns, 182194 ticks, 2.9036 ns/op, 344402889.2 op/s
// Target (idle): 28000000 op, 82.1 ms, 82091740.1 ns, 183968 ticks, 2.9318 ns/op, 341081818.6 op/s
// Target (idle): 28000000 op, 82.5 ms, 82487098.4 ns, 184854 ticks, 2.946 ns/op, 339447023.1 op/s
// Warmup 1: 28000000 op, 1599.4 ms, 1599419010.7 ns, 3584306 ticks, 57.1221 ns/op, 17506356.9 op/s
// Warmup 2: 28000000 op, 1668.1 ms, 1668119883.7 ns, 3738265 ticks, 59.5757 ns/op, 16785364.3 op/s
// Warmup 3: 28000000 op, 1708.4 ms, 1708382623 ns, 3828494 ticks, 61.0137 ns/op, 16389771 op/s
// Warmup 4: 28000000 op, 1768.4 ms, 1768412386.4 ns, 3963021 ticks, 63.1576 ns/op, 15833410.9 op/s
// Warmup 5: 28000000 op, 1719.5 ms, 1719491924.4 ns, 3853390 ticks, 61.4104 ns/op, 16283879.9 op/s
Target 1: 28000000 op, 1720.3 ms, 1720251405.1 ns, 3855092 ticks, 61.4376 ns/op, 16276690.7 op/s
Target 2: 28000000 op, 1705.1 ms, 1705056436.7 ns, 3821040 ticks, 60.8949 ns/op, 16421743.8 op/s
Target 3: 28000000 op, 1672.8 ms, 1672789663.6 ns, 3748730 ticks, 59.7425 ns/op, 16738506.1 op/s
Target 4: 28000000 op, 1605.7 ms, 1605658175.7 ns, 3598288 ticks, 57.3449 ns/op, 17438331.8 op/s
Target 5: 28000000 op, 1608.1 ms, 1608095028.8 ns, 3603749 ticks, 57.432 ns/op, 17411906.3 op/s
Target 6: 28000000 op, 1599.8 ms, 1599772869.8 ns, 3585099 ticks, 57.1347 ns/op, 17502484.6 op/s
Target 7: 28000000 op, 1712 ms, 1711952449.9 ns, 3836494 ticks, 61.1412 ns/op, 16355594.5 op/s
Target 8: 28000000 op, 1700 ms, 1699961847.5 ns, 3809623 ticks, 60.7129 ns/op, 16470957.9 op/s
Target 9: 28000000 op, 1696.2 ms, 1696247442.6 ns, 3801299 ticks, 60.5803 ns/op, 16507025.6 op/s
Target 10: 28000000 op, 1708.4 ms, 1708376822 ns, 3828481 ticks, 61.0135 ns/op, 16389826.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=60.9043446461032 +- 0.680794658574716
OperationsPerSecond: Avr=16434972.8948869 +- 187132.918348125

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
// Pre-Warmup: 1 op, 0 ms, 30343.5 ns, 68 ticks, 30343.5289 ns/op, 32956 op/s
// Pre-Warmup: 1000 op, 9.5 ms, 9528760.5 ns, 21354 ticks, 9528.7605 ns/op, 104945.4 op/s
// Pre-Warmup: 105000 op, 501.9 ms, 501903387.1 ns, 1124768 ticks, 4780.0323 ns/op, 209203.6 op/s
// Pre-Warmup: 210000 op, 847.7 ms, 847667006.5 ns, 1899626 ticks, 4036.5096 ns/op, 247738.8 op/s
// Pre-Warmup: 420000 op, 1542.6 ms, 1542626634 ns, 3457034 ticks, 3672.9206 ns/op, 272262.9 op/s
// Warmup (idle): 420000 op, 1.5 ms, 1452919.6 ns, 3256 ticks, 3.4593 ns/op, 289073126.5 op/s
// Warmup (idle): 420000 op, 1.4 ms, 1415882.6 ns, 3173 ticks, 3.3711 ns/op, 296634762.1 op/s
// Warmup (idle): 420000 op, 1.4 ms, 1389555.1 ns, 3114 ticks, 3.3085 ns/op, 302255009.6 op/s
// IterationCount = 420000
// Target (idle): 420000 op, 1.4 ms, 1430161.9 ns, 3205 ticks, 3.4051 ns/op, 293673042.1 op/s
// Target (idle): 420000 op, 1.4 ms, 1436855.3 ns, 3220 ticks, 3.4211 ns/op, 292305000 op/s
// Target (idle): 420000 op, 1.4 ms, 1352964.4 ns, 3032 ticks, 3.2213 ns/op, 310429452.5 op/s
// Target (idle): 420000 op, 1.4 ms, 1365905 ns, 3061 ticks, 3.2522 ns/op, 307488435.2 op/s
// Target (idle): 420000 op, 1.4 ms, 1358319.1 ns, 3044 ticks, 3.2341 ns/op, 309205683.3 op/s
// Warmup 1: 420000 op, 1518.6 ms, 1518608838.4 ns, 3403210 ticks, 3615.7353 ns/op, 276568.9 op/s
// Warmup 2: 420000 op, 1467.7 ms, 1467655806.2 ns, 3289024 ticks, 3494.4186 ns/op, 286170.6 op/s
// Warmup 3: 420000 op, 1541 ms, 1540955508.8 ns, 3453289 ticks, 3668.9417 ns/op, 272558.2 op/s
// Warmup 4: 420000 op, 1469.5 ms, 1469463923.6 ns, 3293076 ticks, 3498.7236 ns/op, 285818.5 op/s
// Warmup 5: 420000 op, 1464 ms, 1463986916.6 ns, 3280802 ticks, 3485.6831 ns/op, 286887.8 op/s
Target 1: 420000 op, 1614.3 ms, 1614266813.3 ns, 3617580 ticks, 3843.4924 ns/op, 260180 op/s
Target 2: 420000 op, 1652 ms, 1652027103.9 ns, 3702201 ticks, 3933.3979 ns/op, 254233.1 op/s
Target 3: 420000 op, 1649.6 ms, 1649598282.9 ns, 3696758 ticks, 3927.615 ns/op, 254607.4 op/s
Target 4: 420000 op, 1449.9 ms, 1449932508 ns, 3249306 ticks, 3452.2203 ns/op, 289668.7 op/s
Target 5: 420000 op, 1463.6 ms, 1463584864.8 ns, 3279901 ticks, 3484.7259 ns/op, 286966.6 op/s
Target 6: 420000 op, 1464.9 ms, 1464852599.6 ns, 3282742 ticks, 3487.7443 ns/op, 286718.3 op/s
Target 7: 420000 op, 1483 ms, 1482968132.6 ns, 3323339 ticks, 3530.8765 ns/op, 283215.8 op/s
Target 8: 420000 op, 1466 ms, 1466028857.6 ns, 3285378 ticks, 3490.5449 ns/op, 286488.2 op/s
Target 9: 420000 op, 1473.9 ms, 1473928438.4 ns, 3303081 ticks, 3509.3534 ns/op, 284952.8 op/s
Target 10: 420000 op, 1570 ms, 1569950981.8 ns, 3518268 ticks, 3737.9785 ns/op, 267524.3 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 47746.4 ns, 107 ticks, 47746.4352 ns/op, 20944 op/s
// Pre-Warmup: 1000 op, 3.6 ms, 3571611.8 ns, 8004 ticks, 3571.6118 ns/op, 279985.6 op/s
// Pre-Warmup: 280000 op, 1096.1 ms, 1096093940 ns, 2456352 ticks, 3914.6212 ns/op, 255452.6 op/s
// Warmup (idle): 280000 op, 0.9 ms, 899596.4 ns, 2016 ticks, 3.2128 ns/op, 311250694.4 op/s
// Warmup (idle): 280000 op, 0.9 ms, 918784.2 ns, 2059 ticks, 3.2814 ns/op, 304750558.5 op/s
// Warmup (idle): 280000 op, 1.1 ms, 1126280.4 ns, 2524 ticks, 4.0224 ns/op, 248605942.9 op/s
// IterationCount = 280000
// Target (idle): 280000 op, 0.9 ms, 923692.7 ns, 2070 ticks, 3.2989 ns/op, 303131111.1 op/s
// Target (idle): 280000 op, 0.9 ms, 921907.8 ns, 2066 ticks, 3.2925 ns/op, 303718005.8 op/s
// Target (idle): 280000 op, 0.9 ms, 921461.6 ns, 2065 ticks, 3.2909 ns/op, 303865084.7 op/s
// Target (idle): 280000 op, 0.9 ms, 936187.1 ns, 2098 ticks, 3.3435 ns/op, 299085510 op/s
// Target (idle): 280000 op, 1 ms, 1011153.5 ns, 2266 ticks, 3.6113 ns/op, 276911474 op/s
// Warmup 1: 280000 op, 1061.6 ms, 1061606734.5 ns, 2379066 ticks, 3791.4526 ns/op, 263751.2 op/s
// Warmup 2: 280000 op, 1049.6 ms, 1049612116 ns, 2352186 ticks, 3748.6147 ns/op, 266765.2 op/s
// Warmup 3: 280000 op, 1064.7 ms, 1064705344.3 ns, 2386010 ticks, 3802.5191 ns/op, 262983.6 op/s
// Warmup 4: 280000 op, 934.3 ms, 934257621 ns, 2093676 ticks, 3336.6344 ns/op, 299703.2 op/s
// Warmup 5: 280000 op, 938.6 ms, 938630212.8 ns, 2103475 ticks, 3352.2508 ns/op, 298307 op/s
Target 1: 280000 op, 934 ms, 934003270.9 ns, 2093106 ticks, 3335.726 ns/op, 299784.8 op/s
Target 2: 280000 op, 932 ms, 932046559.5 ns, 2088721 ticks, 3328.7377 ns/op, 300414.2 op/s
Target 3: 280000 op, 939.9 ms, 939872958.8 ns, 2106260 ticks, 3356.6891 ns/op, 297912.6 op/s
Target 4: 280000 op, 1075 ms, 1075042224.4 ns, 2409175 ticks, 3839.4365 ns/op, 260454.9 op/s
Target 5: 280000 op, 1073.1 ms, 1073114517.8 ns, 2404855 ticks, 3832.5518 ns/op, 260922.8 op/s
Target 6: 280000 op, 1089.7 ms, 1089740986.7 ns, 2442115 ticks, 3891.9321 ns/op, 256941.8 op/s
Target 7: 280000 op, 1035.7 ms, 1035717903.4 ns, 2321049 ticks, 3698.9925 ns/op, 270343.9 op/s
Target 8: 280000 op, 1068.7 ms, 1068705781.6 ns, 2394975 ticks, 3816.8064 ns/op, 261999.1 op/s
Target 9: 280000 op, 1076.8 ms, 1076761988.5 ns, 2413029 ticks, 3845.5785 ns/op, 260038.9 op/s
Target 10: 280000 op, 1032.7 ms, 1032659900.4 ns, 2314196 ticks, 3688.0711 ns/op, 271144.4 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 39268.1 ns, 88 ticks, 39268.0962 ns/op, 25466 op/s
// Pre-Warmup: 1000 op, 4.9 ms, 4931715.9 ns, 11052 ticks, 4931.7159 ns/op, 202769.2 op/s
// Pre-Warmup: 203000 op, 894 ms, 894002467.6 ns, 2003464 ticks, 4403.953 ns/op, 227068.7 op/s
// Pre-Warmup: 406000 op, 1683.6 ms, 1683586158.9 ns, 3772925 ticks, 4146.7639 ns/op, 241151.9 op/s
// Warmup (idle): 406000 op, 1.4 ms, 1365012.6 ns, 3059 ticks, 3.3621 ns/op, 297433157.9 op/s
// Warmup (idle): 406000 op, 1.4 ms, 1363227.7 ns, 3055 ticks, 3.3577 ns/op, 297822595.7 op/s
// Warmup (idle): 406000 op, 1.4 ms, 1368582.4 ns, 3067 ticks, 3.3709 ns/op, 296657329.6 op/s
// IterationCount = 406000
// Target (idle): 406000 op, 1.4 ms, 1435516.7 ns, 3217 ticks, 3.5358 ns/op, 282825001.6 op/s
// Target (idle): 406000 op, 1.4 ms, 1391340 ns, 3118 ticks, 3.4269 ns/op, 291805012.8 op/s
// Target (idle): 406000 op, 1.4 ms, 1361442.7 ns, 3051 ticks, 3.3533 ns/op, 298213054.7 op/s
// Target (idle): 406000 op, 1.4 ms, 1364120.1 ns, 3057 ticks, 3.3599 ns/op, 297627749.4 op/s
// Target (idle): 406000 op, 1.4 ms, 1383307.9 ns, 3100 ticks, 3.4072 ns/op, 293499364.5 op/s
// Warmup 1: 406000 op, 1486.1 ms, 1486146617.3 ns, 3330462 ticks, 3660.4596 ns/op, 273189.7 op/s
// Warmup 2: 406000 op, 1429.1 ms, 1429113277.3 ns, 3202650 ticks, 3519.9834 ns/op, 284092.2 op/s
// Warmup 3: 406000 op, 1438.1 ms, 1438089607.1 ns, 3222766 ticks, 3542.0926 ns/op, 282319 op/s
// Warmup 4: 406000 op, 1521.2 ms, 1521205441.3 ns, 3409029 ticks, 3746.8114 ns/op, 266893.6 op/s
// Warmup 5: 406000 op, 1697.6 ms, 1697634766.5 ns, 3804408 ticks, 4181.3664 ns/op, 239156.3 op/s
Target 1: 406000 op, 1585.9 ms, 1585943806.5 ns, 3554108 ticks, 3906.2655 ns/op, 255999 op/s
Target 2: 406000 op, 1621.9 ms, 1621939710.1 ns, 3634775 ticks, 3994.9254 ns/op, 250317.6 op/s
Target 3: 406000 op, 1583.1 ms, 1583057155.2 ns, 3547639 ticks, 3899.1556 ns/op, 256465.8 op/s
Target 4: 406000 op, 1633.4 ms, 1633389930 ns, 3660435 ticks, 4023.1279 ns/op, 248562.8 op/s
Target 5: 406000 op, 1993.5 ms, 1993506038.6 ns, 4467457 ticks, 4910.1134 ns/op, 203661.3 op/s
Target 6: 406000 op, 1792.9 ms, 1792888458.5 ns, 4017872 ticks, 4415.9814 ns/op, 226450.2 op/s
Target 7: 406000 op, 1675.5 ms, 1675493361.2 ns, 3754789 ticks, 4126.8309 ns/op, 242316.7 op/s
Target 8: 406000 op, 1779.1 ms, 1779133915.4 ns, 3987048 ticks, 4382.1032 ns/op, 228200.9 op/s
Target 9: 406000 op, 1666 ms, 1666018148.1 ns, 3733555 ticks, 4103.493 ns/op, 243694.8 op/s
Target 10: 406000 op, 1851.6 ms, 1851601848.3 ns, 4149449 ticks, 4560.5957 ns/op, 219269.6 op/s
// Benchmark finished

AverageTime (ns/op): Avr=3845.16876043541 +- 133.83439793915
OperationsPerSecond: Avr=262315.043751743 +- 8624.01070724503

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
// Pre-Warmup: 1 op, 0 ms, 3123.6 ns, 7 ticks, 3123.5986 ns/op, 320143.6 op/s
// Pre-Warmup: 1000 op, 0.1 ms, 66488 ns, 149 ticks, 66.488 ns/op, 15040302 op/s
// Pre-Warmup: 1000000 op, 70.3 ms, 70335853.8 ns, 157623 ticks, 70.3359 ns/op, 14217500 op/s
// Pre-Warmup: 15000000 op, 1127 ms, 1126957325 ns, 2525517 ticks, 75.1305 ns/op, 13310175.7 op/s
// Warmup (idle): 15000000 op, 53.5 ms, 53521968.9 ns, 119943 ticks, 3.5681 ns/op, 280258747.9 op/s
// Warmup (idle): 15000000 op, 53.3 ms, 53302870.8 ns, 119452 ticks, 3.5535 ns/op, 281410734 op/s
// Warmup (idle): 15000000 op, 53.9 ms, 53906171.6 ns, 120804 ticks, 3.5937 ns/op, 278261274.5 op/s
// IterationCount = 15000000
// Target (idle): 15000000 op, 51.9 ms, 51917331.7 ns, 116347 ticks, 3.4612 ns/op, 288920857.4 op/s
// Target (idle): 15000000 op, 53.3 ms, 53323397.3 ns, 119498 ticks, 3.5549 ns/op, 281302406.7 op/s
// Target (idle): 15000000 op, 52.7 ms, 52662086.9 ns, 118016 ticks, 3.5108 ns/op, 284834895.3 op/s
// Target (idle): 15000000 op, 51.1 ms, 51108319.7 ns, 114534 ticks, 3.4072 ns/op, 293494289.9 op/s
// Target (idle): 15000000 op, 49.1 ms, 49130189.4 ns, 110101 ticks, 3.2753 ns/op, 305311259.7 op/s
// Warmup 1: 15000000 op, 1061.2 ms, 1061239042.3 ns, 2378242 ticks, 70.7493 ns/op, 14134421.6 op/s
// Warmup 2: 15000000 op, 1062 ms, 1061991829.6 ns, 2379929 ticks, 70.7995 ns/op, 14124402.5 op/s
// Warmup 3: 15000000 op, 1027.4 ms, 1027388604.7 ns, 2302383 ticks, 68.4926 ns/op, 14600123 op/s
// Warmup 4: 15000000 op, 990.5 ms, 990485518.8 ns, 2219683 ticks, 66.0324 ns/op, 15144088.1 op/s
// Warmup 5: 15000000 op, 1226.2 ms, 1226158353.1 ns, 2747827 ticks, 81.7439 ns/op, 12233330.2 op/s
Target 1: 15000000 op, 1256.7 ms, 1256691975.3 ns, 2816253 ticks, 83.7795 ns/op, 11936099.1 op/s
Target 2: 15000000 op, 1271.5 ms, 1271466596.5 ns, 2849363 ticks, 84.7644 ns/op, 11797400 op/s
Target 3: 15000000 op, 1193 ms, 1192979489.1 ns, 2673473 ticks, 79.532 ns/op, 12573560.7 op/s
Target 4: 15000000 op, 1261.8 ms, 1261789241.9 ns, 2827676 ticks, 84.1193 ns/op, 11887880.7 op/s
Target 5: 15000000 op, 1272 ms, 1271967264.7 ns, 2850485 ticks, 84.7978 ns/op, 11792756.3 op/s
Target 6: 15000000 op, 1240.5 ms, 1240538062.2 ns, 2780052 ticks, 82.7025 ns/op, 12091527.4 op/s
Target 7: 15000000 op, 1175.1 ms, 1175066543.8 ns, 2633330 ticks, 78.3378 ns/op, 12765234.5 op/s
Target 8: 15000000 op, 1026.8 ms, 1026781734.1 ns, 2301023 ticks, 68.4521 ns/op, 14608752.3 op/s
Target 9: 15000000 op, 1082.8 ms, 1082783840.3 ns, 2426524 ticks, 72.1856 ns/op, 13853180.5 op/s
Target 10: 15000000 op, 1073.2 ms, 1073191715.3 ns, 2405028 ticks, 71.5461 ns/op, 13976999.4 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 9370.8 ns, 21 ticks, 9370.7957 ns/op, 106714.5 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 155287.5 ns, 348 ticks, 155.2875 ns/op, 6439669.5 op/s
// Pre-Warmup: 1000000 op, 91.2 ms, 91176503.4 ns, 204327 ticks, 91.1765 ns/op, 10967738 op/s
// Pre-Warmup: 11000000 op, 822.5 ms, 822534086.3 ns, 1843303 ticks, 74.7758 ns/op, 13373306 op/s
// Pre-Warmup: 22000000 op, 1585.8 ms, 1585799674.7 ns, 3553785 ticks, 72.0818 ns/op, 13873126.8 op/s
// Warmup (idle): 22000000 op, 72.3 ms, 72343881.4 ns, 162123 ticks, 3.2884 ns/op, 304103119.2 op/s
// Warmup (idle): 22000000 op, 71.9 ms, 71861954.8 ns, 161043 ticks, 3.2665 ns/op, 306142520.9 op/s
// Warmup (idle): 22000000 op, 71.6 ms, 71643749.1 ns, 160554 ticks, 3.2565 ns/op, 307074940.5 op/s
// IterationCount = 22000000
// Target (idle): 22000000 op, 72.4 ms, 72443390.4 ns, 162346 ticks, 3.2929 ns/op, 303685400.3 op/s
// Target (idle): 22000000 op, 72.3 ms, 72287210.4 ns, 161996 ticks, 3.2858 ns/op, 304341527 op/s
// Target (idle): 22000000 op, 71.6 ms, 71569229 ns, 160387 ticks, 3.2531 ns/op, 307394676.6 op/s
// Target (idle): 22000000 op, 71.7 ms, 71690156.9 ns, 160658 ticks, 3.2586 ns/op, 306876159.3 op/s
// Target (idle): 22000000 op, 72.8 ms, 72846334.6 ns, 163249 ticks, 3.3112 ns/op, 302005586.6 op/s
// Warmup 1: 22000000 op, 1481.7 ms, 1481705752.6 ns, 3320510 ticks, 67.3503 ns/op, 14847752.3 op/s
// Warmup 2: 22000000 op, 1471.7 ms, 1471687033.3 ns, 3298058 ticks, 66.8949 ns/op, 14948830.5 op/s
// Warmup 3: 22000000 op, 1550.5 ms, 1550490070.3 ns, 3474656 ticks, 70.4768 ns/op, 14189062.2 op/s
// Warmup 4: 22000000 op, 1908.4 ms, 1908431261.9 ns, 4276804 ticks, 86.7469 ns/op, 11527792.7 op/s
// Warmup 5: 22000000 op, 1557.2 ms, 1557159845.7 ns, 3489603 ticks, 70.78 ns/op, 14128286.2 op/s
Target 1: 22000000 op, 1535 ms, 1535044767.9 ns, 3440043 ticks, 69.7748 ns/op, 14331829.6 op/s
Target 2: 22000000 op, 1578.7 ms, 1578708659.7 ns, 3537894 ticks, 71.7595 ns/op, 13935440.1 op/s
Target 3: 22000000 op, 1570 ms, 1570017916.1 ns, 3518418 ticks, 71.3645 ns/op, 14012578.9 op/s
Target 4: 22000000 op, 1480.7 ms, 1480715571.8 ns, 3318291 ticks, 67.3053 ns/op, 14857681.3 op/s
Target 5: 22000000 op, 1501.9 ms, 1501891785.2 ns, 3365747 ticks, 68.2678 ns/op, 14648192.5 op/s
Target 6: 22000000 op, 1465.7 ms, 1465654918.2 ns, 3284540 ticks, 66.6207 ns/op, 15010354.6 op/s
Target 7: 22000000 op, 1551.4 ms, 1551422687.6 ns, 3476746 ticks, 70.5192 ns/op, 14180532.6 op/s
Target 8: 22000000 op, 1585.2 ms, 1585228502.4 ns, 3552505 ticks, 72.0558 ns/op, 13878125.4 op/s
Target 9: 22000000 op, 1574.7 ms, 1574748829.2 ns, 3529020 ticks, 71.5795 ns/op, 13970481.9 op/s
Target 10: 22000000 op, 1622.1 ms, 1622056175.7 ns, 3635036 ticks, 73.7298 ns/op, 13563032.1 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 8478.3 ns, 19 ticks, 8478.339 ns/op, 117947.6 op/s
// Pre-Warmup: 1000 op, 0.2 ms, 164212 ns, 368 ticks, 164.212 ns/op, 6089687.5 op/s
// Pre-Warmup: 1000000 op, 91.9 ms, 91860125.3 ns, 205859 ticks, 91.8601 ns/op, 10886116.2 op/s
// Pre-Warmup: 11000000 op, 769.2 ms, 769212920.1 ns, 1723810 ticks, 69.9284 ns/op, 14300331.8 op/s
// Pre-Warmup: 22000000 op, 1531.6 ms, 1531552584.7 ns, 3432217 ticks, 69.616 ns/op, 14364508.4 op/s
// Warmup (idle): 22000000 op, 71.8 ms, 71811531 ns, 160930 ticks, 3.2642 ns/op, 306357484.6 op/s
// Warmup (idle): 22000000 op, 73 ms, 72951198.2 ns, 163484 ticks, 3.316 ns/op, 301571468.8 op/s
// Warmup (idle): 22000000 op, 72.6 ms, 72588860.8 ns, 162672 ticks, 3.2995 ns/op, 303076804.9 op/s
// IterationCount = 22000000
// Target (idle): 22000000 op, 72.3 ms, 72289441.6 ns, 162001 ticks, 3.2859 ns/op, 304332133.8 op/s
// Target (idle): 22000000 op, 71.5 ms, 71472843.7 ns, 160171 ticks, 3.2488 ns/op, 307809216.4 op/s
// Target (idle): 22000000 op, 72.7 ms, 72719159.5 ns, 162964 ticks, 3.3054 ns/op, 302533749.8 op/s
// Target (idle): 22000000 op, 72.2 ms, 72213582.7 ns, 161831 ticks, 3.2824 ns/op, 304651828.1 op/s
// Target (idle): 22000000 op, 71.5 ms, 71524159.9 ns, 160286 ticks, 3.2511 ns/op, 307588373.3 op/s
// Warmup 1: 22000000 op, 1469 ms, 1469028850.9 ns, 3292101 ticks, 66.774 ns/op, 14975880.1 op/s
// Warmup 2: 22000000 op, 1478.8 ms, 1478816423.9 ns, 3314035 ticks, 67.2189 ns/op, 14876762 op/s
// Warmup 3: 22000000 op, 1592.3 ms, 1592318624.9 ns, 3568394 ticks, 72.3781 ns/op, 13816330.3 op/s
// Warmup 4: 22000000 op, 1555.5 ms, 1555524865 ns, 3485939 ticks, 70.7057 ns/op, 14143136.2 op/s
// Warmup 5: 22000000 op, 1578.3 ms, 1578312408.9 ns, 3537006 ticks, 71.7415 ns/op, 13938938.8 op/s
Target 1: 22000000 op, 1575.6 ms, 1575573905.5 ns, 3530869 ticks, 71.617 ns/op, 13963166 op/s
Target 2: 22000000 op, 1565.5 ms, 1565500746.3 ns, 3508295 ticks, 71.1591 ns/op, 14053011.5 op/s
Target 3: 22000000 op, 1564.3 ms, 1564302176.9 ns, 3505609 ticks, 71.1046 ns/op, 14063778.9 op/s
Target 4: 22000000 op, 1579 ms, 1578955424 ns, 3538447 ticks, 71.7707 ns/op, 13933262.2 op/s
Target 5: 22000000 op, 1554.7 ms, 1554745750.2 ns, 3484193 ticks, 70.6703 ns/op, 14150223.6 op/s
Target 6: 22000000 op, 1576.8 ms, 1576843871.4 ns, 3533715 ticks, 71.6747 ns/op, 13951920.3 op/s
Target 7: 22000000 op, 1547.2 ms, 1547160760.5 ns, 3467195 ticks, 70.3255 ns/op, 14219595.4 op/s
Target 8: 22000000 op, 1592.1 ms, 1592062043.6 ns, 3567819 ticks, 72.3665 ns/op, 13818556.9 op/s
Target 9: 22000000 op, 1564.7 ms, 1564685933.3 ns, 3506469 ticks, 71.1221 ns/op, 14060329.6 op/s
Target 10: 22000000 op, 1542.8 ms, 1542843947.2 ns, 3457521 ticks, 70.1293 ns/op, 14259381.2 op/s
// Benchmark finished

AverageTime (ns/op): Avr=73.504455331404 +- 1.94324865881585
OperationsPerSecond: Avr=13671495.526038 +- 335694.456809749

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
// Pre-Warmup: 1 op, 0 ms, 14725.5 ns, 33 ticks, 14725.5361 ns/op, 67909.2 op/s
// Pre-Warmup: 1000 op, 3.4 ms, 3350728.8 ns, 7509 ticks, 3350.7288 ns/op, 298442.5 op/s
// Pre-Warmup: 299000 op, 1059.6 ms, 1059611647.5 ns, 2374595 ticks, 3543.8517 ns/op, 282178.9 op/s
// Warmup (idle): 299000 op, 1 ms, 991965.7 ns, 2223 ticks, 3.3176 ns/op, 301421725.1 op/s
// Warmup (idle): 299000 op, 1 ms, 999105.3 ns, 2239 ticks, 3.3415 ns/op, 299267751.2 op/s
// Warmup (idle): 299000 op, 0.9 ms, 928601.2 ns, 2081 ticks, 3.1057 ns/op, 321989666 op/s
// IterationCount = 299000
// Target (idle): 299000 op, 1 ms, 952697.6 ns, 2135 ticks, 3.1863 ns/op, 313845665.1 op/s
// Target (idle): 299000 op, 0.9 ms, 919676.7 ns, 2061 ticks, 3.0758 ns/op, 325114262.5 op/s
// Target (idle): 299000 op, 0.9 ms, 910305.9 ns, 2040 ticks, 3.0445 ns/op, 328461027 op/s
// Target (idle): 299000 op, 0.9 ms, 908521 ns, 2036 ticks, 3.0385 ns/op, 329106333.5 op/s
// Target (idle): 299000 op, 0.9 ms, 907182.3 ns, 2033 ticks, 3.0341 ns/op, 329591979.8 op/s
// Warmup 1: 299000 op, 1176.9 ms, 1176878231 ns, 2637390 ticks, 3936.0476 ns/op, 254062 op/s
// Warmup 2: 299000 op, 1053.2 ms, 1053164986.2 ns, 2360148 ticks, 3522.2909 ns/op, 283906.1 op/s
// Warmup 3: 299000 op, 1062.1 ms, 1062099816.8 ns, 2380171 ticks, 3552.1733 ns/op, 281517.8 op/s
// Warmup 4: 299000 op, 995.4 ms, 995413218.6 ns, 2230726 ticks, 3329.1412 ns/op, 300377.8 op/s
// Warmup 5: 299000 op, 960.2 ms, 960240160.1 ns, 2151903 ticks, 3211.5056 ns/op, 311380.4 op/s
Target 1: 299000 op, 952.4 ms, 952426255.2 ns, 2134392 ticks, 3185.3721 ns/op, 313935.1 op/s
Target 2: 299000 op, 941.3 ms, 941287948.9 ns, 2109431 ticks, 3148.1202 ns/op, 317649.9 op/s
Target 3: 299000 op, 941.1 ms, 941085361.3 ns, 2108977 ticks, 3147.4427 ns/op, 317718.3 op/s
Target 4: 299000 op, 945.9 ms, 945905520.1 ns, 2119779 ticks, 3163.5636 ns/op, 316099.2 op/s
Target 5: 299000 op, 943.6 ms, 943638680 ns, 2114699 ticks, 3155.9822 ns/op, 316858.6 op/s
Target 6: 299000 op, 1023 ms, 1022953987.2 ns, 2292445 ticks, 3421.2508 ns/op, 292290.8 op/s
Target 7: 299000 op, 1045.2 ms, 1045206949.6 ns, 2342314 ticks, 3495.6754 ns/op, 286067.7 op/s
Target 8: 299000 op, 1143.4 ms, 1143366034.4 ns, 2562289 ticks, 3823.9667 ns/op, 261508.6 op/s
Target 9: 299000 op, 1059.7 ms, 1059719634.7 ns, 2374837 ticks, 3544.2128 ns/op, 282150.1 op/s
Target 10: 299000 op, 1049.1 ms, 1049065040 ns, 2350960 ticks, 3508.5787 ns/op, 285015.7 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 25435 ns, 57 ticks, 25435.0169 ns/op, 39315.9 op/s
// Pre-Warmup: 1000 op, 7.1 ms, 7148578.4 ns, 16020 ticks, 7148.5784 ns/op, 139888 op/s
// Pre-Warmup: 140000 op, 512.8 ms, 512843121.7 ns, 1149284 ticks, 3663.1652 ns/op, 272988 op/s
// Pre-Warmup: 280000 op, 1020.3 ms, 1020265907.5 ns, 2286421 ticks, 3643.8068 ns/op, 274438.3 op/s
// Warmup (idle): 280000 op, 0.8 ms, 835785.7 ns, 1873 ticks, 2.9849 ns/op, 335014095 op/s
// Warmup (idle): 280000 op, 0.9 ms, 876392.5 ns, 1964 ticks, 3.13 ns/op, 319491547.9 op/s
// Warmup (idle): 280000 op, 0.9 ms, 899596.4 ns, 2016 ticks, 3.2128 ns/op, 311250694.4 op/s
// IterationCount = 280000
// Target (idle): 280000 op, 0.9 ms, 902273.8 ns, 2022 ticks, 3.2224 ns/op, 310327101.9 op/s
// Target (idle): 280000 op, 0.9 ms, 857204.7 ns, 1921 ticks, 3.0614 ns/op, 326643102.6 op/s
// Target (idle): 280000 op, 0.9 ms, 858543.4 ns, 1924 ticks, 3.0662 ns/op, 326133783.8 op/s
// Target (idle): 280000 op, 0.9 ms, 885763.3 ns, 1985 ticks, 3.1634 ns/op, 316111536.5 op/s
// Target (idle): 280000 op, 0.9 ms, 854973.5 ns, 1916 ticks, 3.0535 ns/op, 327495511.5 op/s
// Warmup 1: 280000 op, 930.6 ms, 930632908 ns, 2085553 ticks, 3323.689 ns/op, 300870.5 op/s
// Warmup 2: 280000 op, 923.2 ms, 923175093.3 ns, 2068840 ticks, 3297.0539 ns/op, 303301.1 op/s
// Warmup 3: 280000 op, 930.8 ms, 930810506.9 ns, 2085951 ticks, 3324.3232 ns/op, 300813.1 op/s
// Warmup 4: 280000 op, 915.4 ms, 915394209.3 ns, 2051403 ticks, 3269.265 ns/op, 305879.1 op/s
// Warmup 5: 280000 op, 918.3 ms, 918310311.7 ns, 2057938 ticks, 3279.6797 ns/op, 304907.8 op/s
Target 1: 280000 op, 1021.6 ms, 1021557738.6 ns, 2289316 ticks, 3648.4205 ns/op, 274091.2 op/s
Target 2: 280000 op, 991.8 ms, 991808585.9 ns, 2222648 ticks, 3542.1735 ns/op, 282312.5 op/s
Target 3: 280000 op, 1019.6 ms, 1019643418.9 ns, 2285026 ticks, 3641.5836 ns/op, 274605.8 op/s
Target 4: 280000 op, 1129.1 ms, 1129097436.2 ns, 2530313 ticks, 4032.4908 ns/op, 247985.7 op/s
Target 5: 280000 op, 1098.5 ms, 1098538825.2 ns, 2461831 ticks, 3923.3529 ns/op, 254884 op/s
Target 6: 280000 op, 1098.2 ms, 1098245206.9 ns, 2461173 ticks, 3922.3043 ns/op, 254952.2 op/s
Target 7: 280000 op, 1000.5 ms, 1000511377.7 ns, 2242151 ticks, 3573.2549 ns/op, 279856.9 op/s
Target 8: 280000 op, 1020.9 ms, 1020949083.1 ns, 2287952 ticks, 3646.2467 ns/op, 274254.6 op/s
Target 9: 280000 op, 1026.1 ms, 1026138719 ns, 2299582 ticks, 3664.7811 ns/op, 272867.6 op/s
Target 10: 280000 op, 1024.6 ms, 1024632698.3 ns, 2296207 ticks, 3659.4025 ns/op, 273268.7 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 23650.1 ns, 53 ticks, 23650.1034 ns/op, 42283.1 op/s
// Pre-Warmup: 1000 op, 3.9 ms, 3896019.9 ns, 8731 ticks, 3896.0199 ns/op, 256672.2 op/s
// Pre-Warmup: 257000 op, 969.2 ms, 969161603.8 ns, 2171896 ticks, 3771.0568 ns/op, 265177.7 op/s
// Pre-Warmup: 514000 op, 1897.5 ms, 1897475463 ns, 4252252 ticks, 3691.5865 ns/op, 270886.2 op/s
// Warmup (idle): 514000 op, 1.5 ms, 1547966.2 ns, 3469 ticks, 3.0116 ns/op, 332048593.3 op/s
// Warmup (idle): 514000 op, 1.5 ms, 1535918 ns, 3442 ticks, 2.9882 ns/op, 334653274.3 op/s
// Warmup (idle): 514000 op, 1.5 ms, 1532348.2 ns, 3434 ticks, 2.9812 ns/op, 335432897.5 op/s
// IterationCount = 514000
// Target (idle): 514000 op, 1.6 ms, 1572062.5 ns, 3523 ticks, 3.0585 ns/op, 326959003.7 op/s
// Target (idle): 514000 op, 1.6 ms, 1632749.6 ns, 3659 ticks, 3.1766 ns/op, 314806387 op/s
// Target (idle): 514000 op, 1.7 ms, 1688528.1 ns, 3784 ticks, 3.2851 ns/op, 304407127.4 op/s
// Target (idle): 514000 op, 1.6 ms, 1634088.3 ns, 3662 ticks, 3.1792 ns/op, 314548489.9 op/s
// Target (idle): 514000 op, 1.7 ms, 1686297 ns, 3779 ticks, 3.2807 ns/op, 304809888.9 op/s
// Warmup 1: 514000 op, 1859.9 ms, 1859910174.2 ns, 4168068 ticks, 3618.5023 ns/op, 276357.4 op/s
// Warmup 2: 514000 op, 1757.6 ms, 1757565913.5 ns, 3938714 ticks, 3419.3889 ns/op, 292449.9 op/s
// Warmup 3: 514000 op, 2167.4 ms, 2167405249 ns, 4857166 ticks, 4216.7417 ns/op, 237149.9 op/s
// Warmup 4: 514000 op, 2459.3 ms, 2459305534.8 ns, 5511316 ticks, 4784.6411 ns/op, 209002.1 op/s
// Warmup 5: 514000 op, 2076.2 ms, 2076230530.5 ns, 4652843 ticks, 4039.359 ns/op, 247564 op/s
Target 1: 514000 op, 1939.5 ms, 1939497234.5 ns, 4346423 ticks, 3773.3409 ns/op, 265017.1 op/s
Target 2: 514000 op, 1910.9 ms, 1910930586.9 ns, 4282405 ticks, 3717.7638 ns/op, 268978.9 op/s
Target 3: 514000 op, 1717.7 ms, 1717741370.5 ns, 3849467 ticks, 3341.9093 ns/op, 299230.1 op/s
Target 4: 514000 op, 1752.9 ms, 1752901488.4 ns, 3928261 ticks, 3410.3142 ns/op, 293228.1 op/s
Target 5: 514000 op, 1766.9 ms, 1766869774.9 ns, 3959564 ticks, 3437.4898 ns/op, 290910 op/s
Target 6: 514000 op, 1925.2 ms, 1925214357 ns, 4314415 ticks, 3745.5532 ns/op, 266983.3 op/s
Target 7: 514000 op, 1914.7 ms, 1914738699.8 ns, 4290939 ticks, 3725.1726 ns/op, 268443.9 op/s
Target 8: 514000 op, 1866.9 ms, 1866852595.2 ns, 4183626 ticks, 3632.0089 ns/op, 275329.7 op/s
Target 9: 514000 op, 1894.5 ms, 1894493765.1 ns, 4245570 ticks, 3685.7855 ns/op, 271312.6 op/s
Target 10: 514000 op, 1914.9 ms, 1914885062.7 ns, 4291267 ticks, 3725.4573 ns/op, 268423.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=3568.09906279679 +- 86.3817209477093
OperationsPerSecond: Avr=281541.006733687 +- 7022.23893486429

// ***** Competition: Finish  *****

```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=SimpleComparisonTest  Mode=Throughput  .NET=HostFramework  
```

            Method | Platform |       Jit |       AvrTime |      StdDev |          op/s |
------------------ |--------- |---------- |-------------- |------------ |-------------- |
     ManualCompare |      X64 | LegacyJit |   131.5205 ns |   4.9045 ns |  7,603,376.64 |
 ReflectionCompare |      X64 | LegacyJit | 3,859.7102 ns | 269.8845 ns |    259,087.15 |
     ManualCompare |      X64 |    RyuJit |    61.2438 ns |   1.9025 ns | 16,328,222.24 |
 ReflectionCompare |      X64 |    RyuJit | 3,841.4645 ns | 374.0006 ns |    260,317.46 |
     ManualCompare |      X86 | LegacyJit |    71.5982 ns |   5.4304 ns | 13,966,823.95 |
 ReflectionCompare |      X86 | LegacyJit | 3,636.7963 ns | 241.3940 ns |    274,967.76 |

// ***** Competition: End *****
```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=SimpleComparisonTest  Mode=Throughput  .NET=HostFramework  
```

            Method | Platform |       Jit |       AvrTime |      StdDev |          op/s |
------------------ |--------- |---------- |-------------- |------------ |-------------- |
     ManualCompare |      X64 | LegacyJit |   131.52