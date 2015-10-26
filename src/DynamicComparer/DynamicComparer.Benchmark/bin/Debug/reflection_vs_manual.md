// ***** Competition: Start   *****
// Found benchmarks:
//   ComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   ComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   ComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10

// **************************
// Benchmark: ComparisonTest_ManualCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 28558.6 ns, 64 ticks, 28558.6154 ns/op, 35015.7 op/s
// Pre-Warmup: 1000 op, 1.4 ms, 1367243.7 ns, 3064 ticks, 1367.2437 ns/op, 731398.5 op/s
// Pre-Warmup: 732000 op, 1025.5 ms, 1025517122.9 ns, 2298189 ticks, 1400.9797 ns/op, 713786.2 op/s
// Warmup (idle): 732000 op, 2.1 ms, 2100396.9 ns, 4707 ticks, 2.8694 ns/op, 348505557.7 op/s
// Warmup (idle): 732000 op, 2.1 ms, 2116014.9 ns, 4742 ticks, 2.8907 ns/op, 345933289.8 op/s
// Warmup (idle): 732000 op, 2.1 ms, 2118246.1 ns, 4747 ticks, 2.8938 ns/op, 345568919.3 op/s
// IterationCount = 732000
// Target (idle): 732000 op, 2.1 ms, 2137880.1 ns, 4791 ticks, 2.9206 ns/op, 342395253.6 op/s
// Target (idle): 732000 op, 2.3 ms, 2281565.6 ns, 5113 ticks, 3.1169 ns/op, 320832321.5 op/s
// Target (idle): 732000 op, 2.4 ms, 2407402 ns, 5395 ticks, 3.2888 ns/op, 304062216.9 op/s
// Target (idle): 732000 op, 2.2 ms, 2158406.6 ns, 4837 ticks, 2.9486 ns/op, 339139065.5 op/s
// Target (idle): 732000 op, 2.1 ms, 2117799.8 ns, 4746 ticks, 2.8932 ns/op, 345641732 op/s
// Warmup 1: 732000 op, 1040.1 ms, 1040130655.7 ns, 2330938 ticks, 1420.9435 ns/op, 703757.7 op/s
// Warmup 2: 732000 op, 1028.4 ms, 1028401989.3 ns, 2304654 ticks, 1404.9208 ns/op, 711783.9 op/s
// Warmup 3: 732000 op, 978.2 ms, 978165599.8 ns, 2192074 ticks, 1336.2918 ns/op, 748339.5 op/s
// Warmup 4: 732000 op, 977.9 ms, 977936238.4 ns, 2191560 ticks, 1335.9785 ns/op, 748515.1 op/s
// Warmup 5: 732000 op, 941.7 ms, 941691339.4 ns, 2110335 ticks, 1286.4636 ns/op, 777324.8 op/s
Target 1: 732000 op, 936.6 ms, 936648066.4 ns, 2099033 ticks, 1279.5739 ns/op, 781510.2 op/s
Target 2: 732000 op, 944.9 ms, 944925156.3 ns, 2117582 ticks, 1290.8814 ns/op, 774664.5 op/s
Target 3: 732000 op, 942.5 ms, 942520877.9 ns, 2112194 ticks, 1287.5968 ns/op, 776640.6 op/s
Target 4: 732000 op, 949.7 ms, 949691321.5 ns, 2128263 ticks, 1297.3925 ns/op, 770776.8 op/s
Target 5: 732000 op, 945.1 ms, 945138899.7 ns, 2118061 ticks, 1291.1734 ns/op, 774489.3 op/s
Target 6: 732000 op, 934.9 ms, 934881448.3 ns, 2095074 ticks, 1277.1604 ns/op, 782987 op/s
Target 7: 732000 op, 1013.4 ms, 1013408270 ns, 2271053 ticks, 1384.4375 ns/op, 722315 op/s
Target 8: 732000 op, 1009.1 ms, 1009086102 ns, 2261367 ticks, 1378.5329 ns/op, 725408.9 op/s
Target 9: 732000 op, 995.1 ms, 995050881.2 ns, 2229914 ticks, 1359.3591 ns/op, 735640.8 op/s
Target 10: 732000 op, 1021.2 ms, 1021183353 ns, 2288477 ticks, 1395.0592 ns/op, 716815.4 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 16956.7 ns, 38 ticks, 16956.6779 ns/op, 58973.8 op/s
// Pre-Warmup: 1000 op, 1.3 ms, 1268627.2 ns, 2843 ticks, 1268.6272 ns/op, 788253.6 op/s
// Pre-Warmup: 789000 op, 1076.1 ms, 1076060517.5 ns, 2411457 ticks, 1363.8283 ns/op, 733230.1 op/s
// Warmup (idle): 789000 op, 2.3 ms, 2272641.1 ns, 5093 ticks, 2.8804 ns/op, 347173168.1 op/s
// Warmup (idle): 789000 op, 2.3 ms, 2274426 ns, 5097 ticks, 2.8827 ns/op, 346900715.1 op/s
// Warmup (idle): 789000 op, 2.3 ms, 2280673.2 ns, 5111 ticks, 2.8906 ns/op, 345950488.2 op/s
// IterationCount = 789000
// Target (idle): 789000 op, 2.6 ms, 2603742.5 ns, 5835 ticks, 3.3001 ns/op, 303025354.8 op/s
// Target (idle): 789000 op, 2.4 ms, 2402939.8 ns, 5385 ticks, 3.0456 ns/op, 328347807.8 op/s
// Target (idle): 789000 op, 2.5 ms, 2477906.1 ns, 5553 ticks, 3.1406 ns/op, 318414000.5 op/s
// Target (idle): 789000 op, 2.4 ms, 2440869.2 ns, 5470 ticks, 3.0936 ns/op, 323245511 op/s
// Target (idle): 789000 op, 2.3 ms, 2262824 ns, 5071 ticks, 2.868 ns/op, 348679342.3 op/s
// Warmup 1: 789000 op, 1010.9 ms, 1010936611 ns, 2265514 ticks, 1281.2885 ns/op, 780464.4 op/s
// Warmup 2: 789000 op, 1032 ms, 1031958429.4 ns, 2312624 ticks, 1307.9321 ns/op, 764565.7 op/s
// Warmup 3: 789000 op, 1011.1 ms, 1011117779.7 ns, 2265920 ticks, 1281.5181 ns/op, 780324.5 op/s
// Warmup 4: 789000 op, 1011.9 ms, 1011894217.1 ns, 2267660 ticks, 1282.5022 ns/op, 779725.8 op/s
// Warmup 5: 789000 op, 1013.4 ms, 1013449323 ns, 2271145 ticks, 1284.4732 ns/op, 778529.3 op/s
Target 1: 789000 op, 1102.7 ms, 1102710168 ns, 2471179 ticks, 1397.6048 ns/op, 715509.9 op/s
Target 2: 789000 op, 1005.6 ms, 1005605967 ns, 2253568 ticks, 1274.5323 ns/op, 784601.5 op/s
Target 3: 789000 op, 1012.3 ms, 1012313225.5 ns, 2268599 ticks, 1283.0332 ns/op, 779403 op/s
Target 4: 789000 op, 1007.6 ms, 1007592129.4 ns, 2258019 ticks, 1277.0496 ns/op, 783054.9 op/s
Target 5: 789000 op, 1018.8 ms, 1018775504.7 ns, 2283081 ticks, 1291.2237 ns/op, 774459.1 op/s
Target 6: 789000 op, 1018.4 ms, 1018381931.3 ns, 2282199 ticks, 1290.7249 ns/op, 774758.4 op/s
Target 7: 789000 op, 1086.4 ms, 1086428633.6 ns, 2434692 ticks, 1376.9691 ns/op, 726232.7 op/s
Target 8: 789000 op, 1085 ms, 1085006950 ns, 2431506 ticks, 1375.1672 ns/op, 727184.3 op/s
Target 9: 789000 op, 1071.9 ms, 1071909701.2 ns, 2402155 ticks, 1358.5674 ns/op, 736069.5 op/s
Target 10: 789000 op, 1102.6 ms, 1102566036.2 ns, 2470856 ticks, 1397.4221 ns/op, 715603.4 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 16956.7 ns, 38 ticks, 16956.6779 ns/op, 58973.8 op/s
// Pre-Warmup: 1000 op, 1.8 ms, 1828643.8 ns, 4098 ticks, 1828.6438 ns/op, 546853.3 op/s
// Pre-Warmup: 547000 op, 761 ms, 760961265.1 ns, 1705318 ticks, 1391.154 ns/op, 718827.7 op/s
// Pre-Warmup: 1094000 op, 1509.5 ms, 1509462049.4 ns, 3382712 ticks, 1379.7642 ns/op, 724761.5 op/s
// Warmup (idle): 1094000 op, 3.5 ms, 3473887.8 ns, 7785 ticks, 3.1754 ns/op, 314920933.8 op/s
// Warmup (idle): 1094000 op, 3.2 ms, 3160635.5 ns, 7083 ticks, 2.8891 ns/op, 346132919.7 op/s
// Warmup (idle): 1094000 op, 3.2 ms, 3165544 ns, 7094 ticks, 2.8936 ns/op, 345596203.8 op/s
// IterationCount = 1094000
// Target (idle): 1094000 op, 3.5 ms, 3467640.6 ns, 7771 ticks, 3.1697 ns/op, 315488285.9 op/s
// Target (idle): 1094000 op, 3.2 ms, 3150818.5 ns, 7061 ticks, 2.8801 ns/op, 347211368.1 op/s
// Target (idle): 1094000 op, 3.4 ms, 3418555.5 ns, 7661 ticks, 3.1248 ns/op, 320018205.2 op/s
// Target (idle): 1094000 op, 3.3 ms, 3282902.1 ns, 7357 ticks, 3.0008 ns/op, 333241738.5 op/s
// Target (idle): 1094000 op, 3.2 ms, 3154388.3 ns, 7069 ticks, 2.8834 ns/op, 346818428.3 op/s
// Warmup 1: 1094000 op, 1515.1 ms, 1515108623.1 ns, 3395366 ticks, 1384.9256 ns/op, 722060.4 op/s
// Warmup 2: 1094000 op, 1526.5 ms, 1526488338.9 ns, 3420868 ticks, 1395.3275 ns/op, 716677.6 op/s
// Warmup 3: 1094000 op, 1459 ms, 1459026195.8 ns, 3269685 ticks, 1333.662 ns/op, 749815.2 op/s
// Warmup 4: 1094000 op, 1411.2 ms, 1411187837.6 ns, 3162479 ticks, 1289.934 ns/op, 775233.4 op/s
// Warmup 5: 1094000 op, 1422.4 ms, 1422379691.3 ns, 3187560 ticks, 1300.1643 ns/op, 769133.6 op/s
Target 1: 1094000 op, 1411 ms, 1411023179.3 ns, 3162110 ticks, 1289.7835 ns/op, 775323.9 op/s
Target 2: 1094000 op, 1484.5 ms, 1484462105.2 ns, 3326687 ticks, 1356.9123 ns/op, 736967.3 op/s
Target 3: 1094000 op, 1511.3 ms, 1511264812 ns, 3386752 ticks, 1381.4121 ns/op, 723897 op/s
Target 4: 1094000 op, 1502.7 ms, 1502735156.8 ns, 3367637 ticks, 1373.6153 ns/op, 728005.9 op/s
Target 5: 1094000 op, 1504.5 ms, 1504525425 ns, 3371649 ticks, 1375.2518 ns/op, 727139.6 op/s
Target 6: 1094000 op, 1498.1 ms, 1498132311.2 ns, 3357322 ticks, 1369.408 ns/op, 730242.6 op/s
Target 7: 1094000 op, 1509.3 ms, 1509343798.9 ns, 3382447 ticks, 1379.6561 ns/op, 724818.3 op/s
Target 8: 1094000 op, 1501.9 ms, 1501923913.6 ns, 3365819 ticks, 1372.8738 ns/op, 728399.1 op/s
Target 9: 1094000 op, 1536.7 ms, 1536695366.6 ns, 3443742 ticks, 1404.6576 ns/op, 711917.3 op/s
Target 10: 1094000 op, 1512 ms, 1512037679.5 ns, 3388484 ticks, 1382.1185 ns/op, 723526.9 op/s
// Benchmark finished

AverageTime (ns/op): Avr=1341.63835067987 +- 17.0683394059542
OperationsPerSecond: Avr=746278.769558967 +- 9595.68987607242

// **************************
// Benchmark: ComparisonTest_ReflectionCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0.1 ms, 145916.7 ns, 327 ticks, 145916.6758 ns/op, 6853.2 op/s
// Pre-Warmup: 1000 op, 48 ms, 48013726 ns, 107599 ticks, 48013.726 ns/op, 20827.4 op/s
// Pre-Warmup: 21000 op, 780.2 ms, 780236991.9 ns, 1748515 ticks, 37154.1425 ns/op, 26914.9 op/s
// Pre-Warmup: 42000 op, 1492.6 ms, 1492566951 ns, 3344850 ticks, 35537.3084 ns/op, 28139.4 op/s
// Warmup (idle): 42000 op, 0.1 ms, 147255.4 ns, 330 ticks, 3.5061 ns/op, 285218818.2 op/s
// Warmup (idle): 42000 op, 0.1 ms, 136099.7 ns, 305 ticks, 3.2405 ns/op, 308597409.8 op/s
// Warmup (idle): 42000 op, 0.1 ms, 128960 ns, 289 ticks, 3.0705 ns/op, 325682387.5 op/s
// IterationCount = 42000
// Target (idle): 42000 op, 0.1 ms, 123605.3 ns, 277 ticks, 2.943 ns/op, 339791371.8 op/s
// Target (idle): 42000 op, 0.1 ms, 127621.3 ns, 286 ticks, 3.0386 ns/op, 329098636.4 op/s
// Target (idle): 42000 op, 0.1 ms, 130298.7 ns, 292 ticks, 3.1023 ns/op, 322336335.6 op/s
// Target (idle): 42000 op, 0.1 ms, 127175.1 ns, 285 ticks, 3.028 ns/op, 330253368.4 op/s
// Target (idle): 42000 op, 0.1 ms, 124943.9 ns, 280 ticks, 2.9749 ns/op, 336150750 op/s
// Warmup 1: 42000 op, 1377.4 ms, 1377393624.7 ns, 3086746 ticks, 32795.0863 ns/op, 30492.4 op/s
// Warmup 2: 42000 op, 1398.2 ms, 1398234720.6 ns, 3133451 ticks, 33291.3029 ns/op, 30037.9 op/s
// Warmup 3: 42000 op, 1370.8 ms, 1370755085.3 ns, 3071869 ticks, 32637.0258 ns/op, 30640 op/s
// Warmup 4: 42000 op, 1468.6 ms, 1468555402.6 ns, 3291040 ticks, 34965.6048 ns/op, 28599.5 op/s
// Warmup 5: 42000 op, 1522.3 ms, 1522348232.2 ns, 3411590 ticks, 36246.3865 ns/op, 27589 op/s
Target 1: 42000 op, 1662.5 ms, 1662532212.1 ns, 3725743 ticks, 39584.1003 ns/op, 25262.7 op/s
Target 2: 42000 op, 1804.3 ms, 1804277991.3 ns, 4043396 ticks, 42958.9998 ns/op, 23278 op/s
Target 3: 42000 op, 1515.2 ms, 1515163063 ns, 3395488 ticks, 36075.311 ns/op, 27719.8 op/s
Target 4: 42000 op, 1692 ms, 1691968112.5 ns, 3791709 ticks, 40284.9551 ns/op, 24823.2 op/s
Target 5: 42000 op, 1898.9 ms, 1898865464.4 ns, 4255367 ticks, 45211.0825 ns/op, 22118.5 op/s
Target 6: 42000 op, 1687.3 ms, 1687271559 ns, 3781184 ticks, 40173.1324 ns/op, 24892.3 op/s
Target 7: 42000 op, 1398.8 ms, 1398837575.1 ns, 3134802 ticks, 33305.6566 ns/op, 30024.9 op/s
Target 8: 42000 op, 1391.5 ms, 1391482392.9 ns, 3118319 ticks, 33130.5332 ns/op, 30183.6 op/s
Target 9: 42000 op, 1376.9 ms, 1376874214.9 ns, 3085582 ticks, 32782.7194 ns/op, 30503.9 op/s
Target 10: 42000 op, 1561.8 ms, 1561782325.3 ns, 3499962 ticks, 37185.2935 ns/op, 26892.4 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0.2 ms, 150825.2 ns, 338 ticks, 150825.1878 ns/op, 6630.2 op/s
// Pre-Warmup: 1000 op, 35.4 ms, 35429639.8 ns, 79398 ticks, 35429.6398 ns/op, 28225 op/s
// Pre-Warmup: 29000 op, 1102.7 ms, 1102747204.9 ns, 2471262 ticks, 38025.7657 ns/op, 26298 op/s
// Warmup (idle): 29000 op, 0.1 ms, 91923 ns, 206 ticks, 3.1698 ns/op, 315481286.4 op/s
// Warmup (idle): 29000 op, 0.1 ms, 86122.1 ns, 193 ticks, 2.9697 ns/op, 336731321.2 op/s
// Warmup (idle): 29000 op, 0.1 ms, 86122.1 ns, 193 ticks, 2.9697 ns/op, 336731321.2 op/s
// IterationCount = 29000
// Target (idle): 29000 op, 0.1 ms, 89691.9 ns, 201 ticks, 3.0928 ns/op, 323329079.6 op/s
// Target (idle): 29000 op, 0.1 ms, 88799.4 ns, 199 ticks, 3.062 ns/op, 326578618.1 op/s
// Target (idle): 29000 op, 0.1 ms, 90138.1 ns, 202 ticks, 3.1082 ns/op, 321728440.6 op/s
// Target (idle): 29000 op, 0.1 ms, 98170.2 ns, 220 ticks, 3.3852 ns/op, 295405204.5 op/s
// Target (idle): 29000 op, 0.1 ms, 86568.3 ns, 194 ticks, 2.9851 ns/op, 334995592.8 op/s
// Warmup 1: 29000 op, 1069.1 ms, 1069061871.8 ns, 2395773 ticks, 36864.2025 ns/op, 27126.6 op/s
// Warmup 2: 29000 op, 1090.5 ms, 1090464769.2 ns, 2443737 ticks, 37602.2334 ns/op, 26594.2 op/s
// Warmup 3: 29000 op, 1071.4 ms, 1071426435.9 ns, 2401072 ticks, 36945.7392 ns/op, 27066.7 op/s
// Warmup 4: 29000 op, 1095.4 ms, 1095389345.4 ns, 2454773 ticks, 37772.0464 ns/op, 26474.6 op/s
// Warmup 5: 29000 op, 1084.8 ms, 1084782943.4 ns, 2431004 ticks, 37406.3084 ns/op, 26733.5 op/s
Target 1: 29000 op, 1085.3 ms, 1085255945.4 ns, 2432064 ticks, 37422.6188 ns/op, 26721.8 op/s
Target 2: 29000 op, 1101.5 ms, 1101516953.3 ns, 2468505 ticks, 37983.3432 ns/op, 26327.3 op/s
Target 3: 29000 op, 1037.9 ms, 1037912900.7 ns, 2325968 ticks, 35790.1 ns/op, 27940.7 op/s
Target 4: 29000 op, 985.4 ms, 985435998.6 ns, 2208367 ticks, 33980.5517 ns/op, 29428.6 op/s
Target 5: 29000 op, 978.3 ms, 978302145.7 ns, 2192380 ticks, 33734.5567 ns/op, 29643.2 op/s
Target 6: 29000 op, 981.1 ms, 981140604.3 ns, 2198741 ticks, 33832.4346 ns/op, 29557.4 op/s
Target 7: 29000 op, 964 ms, 964003203.9 ns, 2160336 ticks, 33241.4898 ns/op, 30082.9 op/s
Target 8: 29000 op, 1102.5 ms, 1102504456.7 ns, 2470718 ticks, 38017.3951 ns/op, 26303.7 op/s
Target 9: 29000 op, 1095.2 ms, 1095213531.4 ns, 2454379 ticks, 37765.9838 ns/op, 26478.9 op/s
Target 10: 29000 op, 1088.5 ms, 1088520552.2 ns, 2439380 ticks, 37535.1915 ns/op, 26641.7 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0.2 ms, 152610.1 ns, 342 ticks, 152610.1013 ns/op, 6552.6 op/s
// Pre-Warmup: 1000 op, 38.7 ms, 38723697.6 ns, 86780 ticks, 38723.6976 ns/op, 25824 op/s
// Pre-Warmup: 26000 op, 944.1 ms, 944104096.2 ns, 2115742 ticks, 36311.696 ns/op, 27539.3 op/s
// Pre-Warmup: 52000 op, 1773.5 ms, 1773472616.1 ns, 3974361 ticks, 34105.2426 ns/op, 29321 op/s
// Warmup (idle): 52000 op, 0.2 ms, 158857.3 ns, 356 ticks, 3.0549 ns/op, 327337809 op/s
// Warmup (idle): 52000 op, 0.2 ms, 164658.3 ns, 369 ticks, 3.1665 ns/op, 315805582.7 op/s
// Warmup (idle): 52000 op, 0.2 ms, 165104.5 ns, 370 ticks, 3.1751 ns/op, 314952054.1 op/s
// IterationCount = 52000
// Target (idle): 52000 op, 0.2 ms, 165550.7 ns, 371 ticks, 3.1837 ns/op, 314103126.7 op/s
// Target (idle): 52000 op, 0.2 ms, 165997 ns, 372 ticks, 3.1922 ns/op, 313258763.4 op/s
// Target (idle): 52000 op, 0.2 ms, 165997 ns, 372 ticks, 3.1922 ns/op, 313258763.4 op/s
// Target (idle): 52000 op, 0.2 ms, 169566.8 ns, 380 ticks, 3.2609 ns/op, 306663842.1 op/s
// Target (idle): 52000 op, 0.2 ms, 165550.7 ns, 371 ticks, 3.1837 ns/op, 314103126.7 op/s
// Warmup 1: 52000 op, 1695.8 ms, 1695829326.6 ns, 3800362 ticks, 32612.1024 ns/op, 30663.5 op/s
// Warmup 2: 52000 op, 1705.2 ms, 1705214847.8 ns, 3821395 ticks, 32792.5932 ns/op, 30494.7 op/s
// Warmup 3: 52000 op, 1808.4 ms, 1808402480.1 ns, 4052639 ticks, 34776.9708 ns/op, 28754.7 op/s
// Warmup 4: 52000 op, 1902.8 ms, 1902844036.5 ns, 4264283 ticks, 36593.1545 ns/op, 27327.5 op/s
// Warmup 5: 52000 op, 1909 ms, 1909011358.7 ns, 4278104 ticks, 36711.7569 ns/op, 27239.2 op/s
Target 1: 52000 op, 1708.4 ms, 1708420998.6 ns, 3828580 ticks, 32854.25 ns/op, 30437.5 op/s
Target 2: 52000 op, 1688.9 ms, 1688881104.7 ns, 3784791 ticks, 32478.4828 ns/op, 30789.6 op/s
Target 3: 52000 op, 1712.4 ms, 1712438392.6 ns, 3837583 ticks, 32931.5075 ns/op, 30366.1 op/s
Target 4: 52000 op, 1945.6 ms, 1945611009.3 ns, 4360124 ticks, 37415.5963 ns/op, 26726.8 op/s
Target 5: 52000 op, 1917.2 ms, 1917221514.5 ns, 4296503 ticks, 36869.6445 ns/op, 27122.6 op/s
Target 6: 52000 op, 1907.9 ms, 1907889094.4 ns, 4275589 ticks, 36690.1749 ns/op, 27255.3 op/s
Target 7: 52000 op, 1887.5 ms, 1887471469.3 ns, 4229833 ticks, 36297.5283 ns/op, 27550.1 op/s
Target 8: 52000 op, 1870.3 ms, 1870338531.2 ns, 4191438 ticks, 35968.0487 ns/op, 27802.5 op/s
Target 9: 52000 op, 1924.4 ms, 1924391511.8 ns, 4312571 ticks, 37007.5291 ns/op, 27021.5 op/s
Target 10: 52000 op, 1925.5 ms, 1925541442.3 ns, 4315148 ticks, 37029.6431 ns/op, 27005.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=36517.9284666306 +- 1102.51231234997
OperationsPerSecond: Avr=27563.4204032335 +- 792.652890005204

// **************************
// Benchmark: ComparisonTest_ManualCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 28112.4 ns, 63 ticks, 28112.3871 ns/op, 35571.5 op/s
// Pre-Warmup: 1000 op, 1.7 ms, 1745199.1 ns, 3911 ticks, 1745.1991 ns/op, 573000.5 op/s
// Pre-Warmup: 574000 op, 551 ms, 551047409.5 ns, 1234900 ticks, 960.0129 ns/op, 1041652.7 op/s
// Pre-Warmup: 1148000 op, 1077.2 ms, 1077164486.5 ns, 2413931 ticks, 938.2966 ns/op, 1065761.1 op/s
// Warmup (idle): 1148000 op, 3.3 ms, 3316815.4 ns, 7433 ticks, 2.8892 ns/op, 346115127.1 op/s
// Warmup (idle): 1148000 op, 3.3 ms, 3270407.7 ns, 7329 ticks, 2.8488 ns/op, 351026571.2 op/s
// Warmup (idle): 1148000 op, 3.7 ms, 3682276.5 ns, 8252 ticks, 3.2076 ns/op, 311763662.1 op/s
// IterationCount = 1148000
// Target (idle): 1148000 op, 3.3 ms, 3301643.7 ns, 7399 ticks, 2.876 ns/op, 347705600.8 op/s
// Target (idle): 1148000 op, 3.3 ms, 3318600.4 ns, 7437 ticks, 2.8908 ns/op, 345928968.7 op/s
// Target (idle): 1148000 op, 3.3 ms, 3313245.6 ns, 7425 ticks, 2.8861 ns/op, 346488045.8 op/s
// Target (idle): 1148000 op, 3.3 ms, 3265053 ns, 7317 ticks, 2.8441 ns/op, 351602260.5 op/s
// Target (idle): 1148000 op, 3.6 ms, 3620697 ns, 8114 ticks, 3.1539 ns/op, 317066026.6 op/s
// Warmup 1: 1148000 op, 1105.9 ms, 1105883744.1 ns, 2478291 ticks, 963.3134 ns/op, 1038083.8 op/s
// Warmup 2: 1148000 op, 1070 ms, 1070048482.7 ns, 2397984 ticks, 932.098 ns/op, 1072848.6 op/s
// Warmup 3: 1148000 op, 1060.6 ms, 1060636634 ns, 2376892 ticks, 923.8995 ns/op, 1082368.8 op/s
// Warmup 4: 1148000 op, 1025 ms, 1025043674.6 ns, 2297128 ticks, 892.8952 ns/op, 1119952.3 op/s
// Warmup 5: 1148000 op, 1009.7 ms, 1009720192.5 ns, 2262788 ticks, 879.5472 ns/op, 1136948.6 op/s
Target 1: 1148000 op, 1017.6 ms, 1017619773.3 ns, 2280491 ticks, 886.4284 ns/op, 1128122.7 op/s
Target 2: 1148000 op, 1018.8 ms, 1018771488.7 ns, 2283072 ticks, 887.4316 ns/op, 1126847.4 op/s
Target 3: 1148000 op, 1009.3 ms, 1009345806.9 ns, 2261949 ticks, 879.2211 ns/op, 1137370.4 op/s
Target 4: 1148000 op, 1006.8 ms, 1006849605.4 ns, 2256355 ticks, 877.0467 ns/op, 1140190.1 op/s
Target 5: 1148000 op, 1084.2 ms, 1084160901 ns, 2429610 ticks, 944.391 ns/op, 1058883.4 op/s
Target 6: 1148000 op, 1107.2 ms, 1107219751.9 ns, 2481285 ticks, 964.4771 ns/op, 1036831.2 op/s
Target 7: 1148000 op, 1089.1 ms, 1089146164.3 ns, 2440782 ticks, 948.7336 ns/op, 1054036.7 op/s
Target 8: 1148000 op, 1086.2 ms, 1086219798.7 ns, 2434224 ticks, 946.1845 ns/op, 1056876.3 op/s
Target 9: 1148000 op, 1004.4 ms, 1004403381.5 ns, 2250873 ticks, 874.9158 ns/op, 1142967.1 op/s
Target 10: 1148000 op, 1011.4 ms, 1011358743.1 ns, 2266460 ticks, 880.9745 ns/op, 1135106.6 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 11155.7 ns, 25 ticks, 11155.7092 ns/op, 89640.2 op/s
// Pre-Warmup: 1000 op, 0.9 ms, 875946.3 ns, 1963 ticks, 875.9463 ns/op, 1141622.5 op/s
// Pre-Warmup: 1000000 op, 944.1 ms, 944083569.6 ns, 2115696 ticks, 944.0836 ns/op, 1059228.3 op/s
// Pre-Warmup: 2000000 op, 1913.4 ms, 1913446868.7 ns, 4288044 ticks, 956.7234 ns/op, 1045234.1 op/s
// Warmup (idle): 2000000 op, 5.8 ms, 5819710.4 ns, 13042 ticks, 2.9099 ns/op, 343659714.8 op/s
// Warmup (idle): 2000000 op, 6.1 ms, 6099049.3 ns, 13668 ticks, 3.0495 ns/op, 327919959 op/s
// Warmup (idle): 2000000 op, 5.7 ms, 5691642.8 ns, 12755 ticks, 2.8458 ns/op, 351392395.1 op/s
// IterationCount = 2000000
// Target (idle): 2000000 op, 6.1 ms, 6077630.3 ns, 13620 ticks, 3.0388 ns/op, 329075624.1 op/s
// Target (idle): 2000000 op, 6.1 ms, 6078522.8 ns, 13622 ticks, 3.0393 ns/op, 329027308.8 op/s
// Target (idle): 2000000 op, 6.3 ms, 6296282.2 ns, 14110 ticks, 3.1481 ns/op, 317647767.5 op/s
// Target (idle): 2000000 op, 6.7 ms, 6687624.5 ns, 14987 ticks, 3.3438 ns/op, 299059851.9 op/s
// Target (idle): 2000000 op, 6.6 ms, 6641663 ns, 14884 ticks, 3.3208 ns/op, 301129400.7 op/s
// Warmup 1: 2000000 op, 1882.5 ms, 1882477727.6 ns, 4218642 ticks, 941.2389 ns/op, 1062429.6 op/s
// Warmup 2: 2000000 op, 1891.7 ms, 1891695020.8 ns, 4239298 ticks, 945.8475 ns/op, 1057252.9 op/s
// Warmup 3: 2000000 op, 1898 ms, 1898034587.2 ns, 4253505 ticks, 949.0173 ns/op, 1053721.6 op/s
// Warmup 4: 2000000 op, 1937.4 ms, 1937378988.4 ns, 4341676 ticks, 968.6895 ns/op, 1032322.5 op/s
// Warmup 5: 2000000 op, 1850.7 ms, 1850713407.6 ns, 4147458 ticks, 925.3567 ns/op, 1080664.3 op/s
Target 1: 2000000 op, 1767.2 ms, 1767220956.7 ns, 3960351 ticks, 883.6105 ns/op, 1131720.4 op/s
Target 2: 2000000 op, 1757.4 ms, 1757393669.4 ns, 3938328 ticks, 878.6968 ns/op, 1138048.9 op/s
Target 3: 2000000 op, 1787.2 ms, 1787220019.6 ns, 4005169 ticks, 893.61 ns/op, 1119056.4 op/s
Target 4: 2000000 op, 1763.1 ms, 1763059430.9 ns, 3951025 ticks, 881.5297 ns/op, 1134391.7 op/s
Target 5: 2000000 op, 1744.8 ms, 1744759159.4 ns, 3910014 ticks, 872.3796 ns/op, 1146290 op/s
Target 6: 2000000 op, 1850.8 ms, 1850781680.5 ns, 4147611 ticks, 925.3908 ns/op, 1080624.5 op/s
Target 7: 2000000 op, 1904.2 ms, 1904180044.2 ns, 4267277 ticks, 952.09 ns/op, 1050320.8 op/s
Target 8: 2000000 op, 1984.8 ms, 1984784058.9 ns, 4447911 ticks, 992.392 ns/op, 1007666.3 op/s
Target 9: 2000000 op, 1882.8 ms, 1882836049 ns, 4219445 ticks, 941.418 ns/op, 1062227.4 op/s
Target 10: 2000000 op, 1872.7 ms, 1872722729.3 ns, 4196781 ticks, 936.3614 ns/op, 1067963.8 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 22757.6 ns, 51 ticks, 22757.6467 ns/op, 43941.3 op/s
// Pre-Warmup: 1000 op, 1.4 ms, 1424360.9 ns, 3192 ticks, 1424.3609 ns/op, 702069.2 op/s
// Pre-Warmup: 703000 op, 679.5 ms, 679547345.9 ns, 1522869 ticks, 966.6392 ns/op, 1034512.2 op/s
// Pre-Warmup: 1406000 op, 1334.7 ms, 1334690462.5 ns, 2991048 ticks, 949.282 ns/op, 1053427.8 op/s
// Warmup (idle): 1406000 op, 4.1 ms, 4094591.5 ns, 9176 ticks, 2.9122 ns/op, 343379798.4 op/s
// Warmup (idle): 1406000 op, 4 ms, 4011593 ns, 8990 ticks, 2.8532 ns/op, 350484208 op/s
// Warmup (idle): 1406000 op, 4.2 ms, 4191423 ns, 9393 ticks, 2.9811 ns/op, 335446931.8 op/s
// IterationCount = 1406000
// Target (idle): 1406000 op, 4.1 ms, 4070941.4 ns, 9123 ticks, 2.8954 ns/op, 345374660.7 op/s
// Target (idle): 1406000 op, 4.1 ms, 4051307.3 ns, 9079 ticks, 2.8814 ns/op, 347048466.8 op/s
// Target (idle): 1406000 op, 4.2 ms, 4194546.6 ns, 9400 ticks, 2.9833 ns/op, 335197130.9 op/s
// Target (idle): 1406000 op, 4.5 ms, 4454697.8 ns, 9983 ticks, 3.1683 ns/op, 315621860.2 op/s
// Target (idle): 1406000 op, 4.2 ms, 4221766.6 ns, 9461 ticks, 3.0027 ns/op, 333035940.2 op/s
// Warmup 1: 1406000 op, 1244.4 ms, 1244419802.7 ns, 2788751 ticks, 885.0781 ns/op, 1129843.8 op/s
// Warmup 2: 1406000 op, 1239.4 ms, 1239365820.2 ns, 2777425 ticks, 881.4835 ns/op, 1134451.2 op/s
// Warmup 3: 1406000 op, 1238.8 ms, 1238771890.3 ns, 2776094 ticks, 881.0611 ns/op, 1134995.1 op/s
// Warmup 4: 1406000 op, 1237.9 ms, 1237872293.9 ns, 2774078 ticks, 880.4213 ns/op, 1135819.9 op/s
// Warmup 5: 1406000 op, 1234.8 ms, 1234810721.1 ns, 2767217 ticks, 878.2438 ns/op, 1138636 op/s
Target 1: 1406000 op, 1225.8 ms, 1225836176.2 ns, 2747105 ticks, 871.8607 ns/op, 1146972.2 op/s
Target 2: 1406000 op, 1248.3 ms, 1248301543.3 ns, 2797450 ticks, 887.8389 ns/op, 1126330.4 op/s
Target 3: 1406000 op, 1259.6 ms, 1259557653.8 ns, 2822675 ticks, 895.8447 ns/op, 1116264.9 op/s
Target 4: 1406000 op, 1340.4 ms, 1340410664 ns, 3003867 ticks, 953.3504 ns/op, 1048932.3 op/s
Target 5: 1406000 op, 1334.3 ms, 1334261190.8 ns, 2990086 ticks, 948.9767 ns/op, 1053766.7 op/s
Target 6: 1406000 op, 1323.6 ms, 1323551263.8 ns, 2966085 ticks, 941.3594 ns/op, 1062293.6 op/s
Target 7: 1406000 op, 1338.2 ms, 1338178183.4 ns, 2998864 ticks, 951.7626 ns/op, 1050682.2 op/s
Target 8: 1406000 op, 1409.2 ms, 1409207922.3 ns, 3158042 ticks, 1002.2816 ns/op, 997723.6 op/s
Target 9: 1406000 op, 1417.6 ms, 1417626020.5 ns, 3176907 ticks, 1008.2689 ns/op, 991799 op/s
Target 10: 1406000 op, 1400.1 ms, 1400114680.7 ns, 3137664 ticks, 995.8141 ns/op, 1004203.5 op/s
// Benchmark finished

AverageTime (ns/op): Avr=923.488041074993 +- 15.6026980827385
OperationsPerSecond: Avr=1085150.34782925 +- 18041.3411000514

// **************************
// Benchmark: ComparisonTest_ReflectionCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0.1 ms, 100401.4 ns, 225 ticks, 100401.3824 ns/op, 9960 op/s
// Pre-Warmup: 1000 op, 35.5 ms, 35505052.4 ns, 79567 ticks, 35505.0524 ns/op, 28165 op/s
// Pre-Warmup: 29000 op, 1099.2 ms, 1099168899.7 ns, 2463243 ticks, 37902.3759 ns/op, 26383.6 op/s
// Warmup (idle): 29000 op, 0.1 ms, 105756.1 ns, 237 ticks, 3.6468 ns/op, 274215801.7 op/s
// Warmup (idle): 29000 op, 0.1 ms, 97724 ns, 219 ticks, 3.3698 ns/op, 296754086.8 op/s
// Warmup (idle): 29000 op, 0.1 ms, 99062.7 ns, 222 ticks, 3.416 ns/op, 292743896.4 op/s
// IterationCount = 29000
// Target (idle): 29000 op, 0.1 ms, 98616.5 ns, 221 ticks, 3.4006 ns/op, 294068529.4 op/s
// Target (idle): 29000 op, 0.1 ms, 98616.5 ns, 221 ticks, 3.4006 ns/op, 294068529.4 op/s
// Target (idle): 29000 op, 0.1 ms, 98170.2 ns, 220 ticks, 3.3852 ns/op, 295405204.5 op/s
// Target (idle): 29000 op, 0.1 ms, 99508.9 ns, 223 ticks, 3.4313 ns/op, 291431143.5 op/s
// Target (idle): 29000 op, 0.1 ms, 99062.7 ns, 222 ticks, 3.416 ns/op, 292743896.4 op/s
// Warmup 1: 29000 op, 1042.4 ms, 1042387232.5 ns, 2335995 ticks, 35944.3873 ns/op, 27820.8 op/s
// Warmup 2: 29000 op, 977.3 ms, 977339631.1 ns, 2190223 ticks, 33701.3666 ns/op, 29672.4 op/s
// Warmup 3: 29000 op, 983 ms, 983041983.4 ns, 2203002 ticks, 33897.9994 ns/op, 29500.3 op/s
// Warmup 4: 29000 op, 983.4 ms, 983390041.5 ns, 2203782 ticks, 33910.0014 ns/op, 29489.8 op/s
// Warmup 5: 29000 op, 977.3 ms, 977300363 ns, 2190135 ticks, 33700.0125 ns/op, 29673.6 op/s
Target 1: 29000 op, 1047.1 ms, 1047134656.1 ns, 2346634 ticks, 36108.0916 ns/op, 27694.6 op/s
Target 2: 29000 op, 1076.4 ms, 1076391618.9 ns, 2412199 ticks, 37116.9524 ns/op, 26941.9 op/s
Target 3: 29000 op, 1098 ms, 1098001120 ns, 2460626 ticks, 37862.1076 ns/op, 26411.6 op/s
Target 4: 29000 op, 1098.2 ms, 1098229142.7 ns, 2461137 ticks, 37869.9704 ns/op, 26406.1 op/s
Target 5: 29000 op, 1091.1 ms, 1091079671.8 ns, 2445115 ticks, 37623.437 ns/op, 26579.2 op/s
Target 6: 29000 op, 1123.9 ms, 1123897983.3 ns, 2518661 ticks, 38755.1029 ns/op, 25803.1 op/s
Target 7: 29000 op, 1097.6 ms, 1097568278.5 ns, 2459656 ticks, 37847.182 ns/op, 26422 op/s
Target 8: 29000 op, 1051.7 ms, 1051680384.5 ns, 2356821 ticks, 36264.8408 ns/op, 27574.9 op/s
Target 9: 29000 op, 973.8 ms, 973790330.7 ns, 2182269 ticks, 33578.9769 ns/op, 29780.5 op/s
Target 10: 29000 op, 1036.3 ms, 1036268549.2 ns, 2322283 ticks, 35733.3982 ns/op, 27985 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0.1 ms, 99062.7 ns, 222 ticks, 99062.6973 ns/op, 10094.6 op/s
// Pre-Warmup: 1000 op, 37.3 ms, 37308707.5 ns, 83609 ticks, 37308.7075 ns/op, 26803.4 op/s
// Pre-Warmup: 27000 op, 1008.2 ms, 1008154377.2 ns, 2259279 ticks, 37339.051 ns/op, 26781.6 op/s
// Warmup (idle): 27000 op, 0.1 ms, 97277.8 ns, 218 ticks, 3.6029 ns/op, 277555665.1 op/s
// Warmup (idle): 27000 op, 0.1 ms, 91476.8 ns, 205 ticks, 3.388 ns/op, 295156756.1 op/s
// Warmup (idle): 27000 op, 0.1 ms, 90584.4 ns, 203 ticks, 3.355 ns/op, 298064704.4 op/s
// IterationCount = 27000
// Target (idle): 27000 op, 0.1 ms, 92369.3 ns, 207 ticks, 3.4211 ns/op, 292305000 op/s
// Target (idle): 27000 op, 0.1 ms, 95939.1 ns, 215 ticks, 3.5533 ns/op, 281428534.9 op/s
// Target (idle): 27000 op, 0.1 ms, 92369.3 ns, 207 ticks, 3.4211 ns/op, 292305000 op/s
// Target (idle): 27000 op, 0.1 ms, 91923 ns, 206 ticks, 3.4046 ns/op, 293723956.3 op/s
// Target (idle): 27000 op, 0.1 ms, 90138.1 ns, 202 ticks, 3.3384 ns/op, 299540272.3 op/s
// Warmup 1: 27000 op, 877.6 ms, 877553151.4 ns, 1966601 ticks, 32501.9686 ns/op, 30767.4 op/s
// Warmup 2: 27000 op, 873.5 ms, 873463022.2 ns, 1957435 ticks, 32350.4823 ns/op, 30911.4 op/s
// Warmup 3: 27000 op, 873.3 ms, 873343879.2 ns, 1957168 ticks, 32346.0696 ns/op, 30915.7 op/s
// Warmup 4: 27000 op, 867.5 ms, 867534878.3 ns, 1944150 ticks, 32130.9214 ns/op, 31122.7 op/s
// Warmup 5: 27000 op, 872.1 ms, 872096670.9 ns, 1954373 ticks, 32299.8767 ns/op, 30959.9 op/s
Target 1: 27000 op, 878.7 ms, 878667383.6 ns, 1969098 ticks, 32543.2364 ns/op, 30728.4 op/s
Target 2: 27000 op, 871 ms, 870981546.2 ns, 1951874 ticks, 32258.5758 ns/op, 30999.5 op/s
Target 3: 27000 op, 1024.4 ms, 1024351128.2 ns, 2295576 ticks, 37938.9307 ns/op, 26358.1 op/s
Target 4: 27000 op, 974.7 ms, 974682341.2 ns, 2184268 ticks, 36099.346 ns/op, 27701.3 op/s
Target 5: 27000 op, 956.5 ms, 956527093.9 ns, 2143582 ticks, 35426.9294 ns/op, 28227.1 op/s
Target 6: 27000 op, 1175 ms, 1175034415.4 ns, 2633258 ticks, 43519.7932 ns/op, 22978.1 op/s
Target 7: 27000 op, 1227.5 ms, 1227457770.1 ns, 2750739 ticks, 45461.3989 ns/op, 21996.7 op/s
Target 8: 27000 op, 1197.6 ms, 1197609108.4 ns, 2683848 ticks, 44355.8929 ns/op, 22544.9 op/s
Target 9: 27000 op, 1193.4 ms, 1193427502.4 ns, 2674477 ticks, 44201.0186 ns/op, 22623.9 op/s
Target 10: 27000 op, 1239.1 ms, 1239144044.7 ns, 2776928 ticks, 45894.2239 ns/op, 21789.2 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0.1 ms, 115126.9 ns, 258 ticks, 115126.9185 ns/op, 8686.1 op/s
// Pre-Warmup: 1000 op, 37.2 ms, 37180193.7 ns, 83321 ticks, 37180.1937 ns/op, 26896 op/s
// Pre-Warmup: 27000 op, 898.5 ms, 898520976.1 ns, 2013590 ticks, 33278.5547 ns/op, 30049.4 op/s
// Pre-Warmup: 54000 op, 1811.9 ms, 1811870120.8 ns, 4060410 ticks, 33553.1504 ns/op, 29803.5 op/s
// Warmup (idle): 54000 op, 0.2 ms, 184292.3 ns, 413 ticks, 3.4128 ns/op, 293012760.3 op/s
// Warmup (idle): 54000 op, 0.2 ms, 187415.9 ns, 420 ticks, 3.4707 ns/op, 288129214.3 op/s
// Warmup (idle): 54000 op, 0.2 ms, 181168.7 ns, 406 ticks, 3.355 ns/op, 298064704.4 op/s
// IterationCount = 54000
// Target (idle): 54000 op, 0.2 ms, 182061.2 ns, 408 ticks, 3.3715 ns/op, 296603602.9 op/s
// Target (idle): 54000 op, 0.2 ms, 187415.9 ns, 420 ticks, 3.4707 ns/op, 288129214.3 op/s
// Target (idle): 54000 op, 0.3 ms, 344488.3 ns, 772 ticks, 6.3794 ns/op, 156754235.8 op/s
// Target (idle): 54000 op, 0.2 ms, 211512.2 ns, 474 ticks, 3.9169 ns/op, 255304367.1 op/s
// Target (idle): 54000 op, 0.2 ms, 230700.1 ns, 517 ticks, 4.2722 ns/op, 234070154.7 op/s
// Warmup 1: 54000 op, 1821.4 ms, 1821408252.1 ns, 4081785 ticks, 33729.7824 ns/op, 29647.4 op/s
// Warmup 2: 54000 op, 1993 ms, 1993046423.4 ns, 4466427 ticks, 36908.2671 ns/op, 27094.2 op/s
// Warmup 3: 54000 op, 1857.5 ms, 1857497863.7 ns, 4162662 ticks, 34398.1086 ns/op, 29071.4 op/s
// Warmup 4: 54000 op, 1814.4 ms, 1814403805.4 ns, 4066088 ticks, 33600.0705 ns/op, 29761.8 op/s
// Warmup 5: 54000 op, 1812 ms, 1812006220.4 ns, 4060715 ticks, 33555.6707 ns/op, 29801.2 op/s
Target 1: 54000 op, 2057.2 ms, 2057200229.4 ns, 4610196 ticks, 38096.3005 ns/op, 26249.3 op/s
Target 2: 54000 op, 1981.9 ms, 1981935783.3 ns, 4441528 ticks, 36702.5145 ns/op, 27246.1 op/s
Target 3: 54000 op, 1901.6 ms, 1901569162.1 ns, 4261426 ticks, 35214.2437 ns/op, 28397.6 op/s
Target 4: 54000 op, 1831.6 ms, 1831575565.4 ns, 4104570 ticks, 33918.066 ns/op, 29482.8 op/s
Target 5: 54000 op, 1814.6 ms, 1814626473.4 ns, 4066587 ticks, 33604.194 ns/op, 29758.2 op/s
Target 6: 54000 op, 2028.4 ms, 2028419392.2 ns, 4545698 ticks, 37563.3221 ns/op, 26621.7 op/s
Target 7: 54000 op, 2023.6 ms, 2023576029.5 ns, 4534844 ticks, 37473.6302 ns/op, 26685.4 op/s
Target 8: 54000 op, 1955.4 ms, 1955390996.5 ns, 4382041 ticks, 36210.9444 ns/op, 27616 op/s
Target 9: 54000 op, 1823 ms, 1823047695.1 ns, 4085459 ticks, 33760.1425 ns/op, 29620.7 op/s
Target 10: 54000 op, 1807.6 ms, 1807604177.6 ns, 4050850 ticks, 33474.1514 ns/op, 29873.8 op/s
// Benchmark finished

AverageTime (ns/op): Avr=37415.8971633908 +- 1346.23939293675
OperationsPerSecond: Avr=26969.9290944562 +- 901.122208506077

// **************************
// Benchmark: ComparisonTest_ManualCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 17402.9 ns, 39 ticks, 17402.9063 ns/op, 57461.7 op/s
// Pre-Warmup: 1000 op, 1.1 ms, 1061577.3 ns, 2379 ticks, 1061.5773 ns/op, 941994.5 op/s
// Pre-Warmup: 942000 op, 908 ms, 907989049.6 ns, 2034808 ticks, 963.895 ns/op, 1037457.4 op/s
// Pre-Warmup: 1884000 op, 1779.6 ms, 1779616734.5 ns, 3988130 ticks, 944.5949 ns/op, 1058654.9 op/s
// Warmup (idle): 1884000 op, 5.6 ms, 5552865.8 ns, 12444 ticks, 2.9474 ns/op, 339284267.1 op/s
// Warmup (idle): 1884000 op, 5.4 ms, 5357417.8 ns, 12006 ticks, 2.8436 ns/op, 351661954 op/s
// Warmup (idle): 1884000 op, 5.5 ms, 5466297.5 ns, 12250 ticks, 2.9014 ns/op, 344657422 op/s
// IterationCount = 1884000
// Target (idle): 1884000 op, 5.4 ms, 5384637.7 ns, 12067 ticks, 2.8581 ns/op, 349884264.5 op/s
// Target (idle): 1884000 op, 5.5 ms, 5481915.5 ns, 12285 ticks, 2.9097 ns/op, 343675492.1 op/s
// Target (idle): 1884000 op, 5.7 ms, 5651928.5 ns, 12666 ticks, 3 ns/op, 333337550.9 op/s
// Target (idle): 1884000 op, 5.4 ms, 5359202.7 ns, 12010 ticks, 2.8446 ns/op, 351544831 op/s
// Target (idle): 1884000 op, 5.6 ms, 5574731 ns, 12493 ticks, 2.959 ns/op, 337953527.6 op/s
// Warmup 1: 1884000 op, 1667.8 ms, 1667779411.5 ns, 3737502 ticks, 885.2332 ns/op, 1129645.8 op/s
// Warmup 2: 1884000 op, 1678.5 ms, 1678506741.4 ns, 3761542 ticks, 890.9271 ns/op, 1122426.2 op/s
// Warmup 3: 1884000 op, 1749.1 ms, 1749100068.9 ns, 3919742 ticks, 928.3971 ns/op, 1077125.3 op/s
// Warmup 4: 1884000 op, 1797.7 ms, 1797742530.7 ns, 4028750 ticks, 954.2158 ns/op, 1047981 op/s
// Warmup 5: 1884000 op, 1785.5 ms, 1785477497.8 ns, 4001264 ticks, 947.7057 ns/op, 1055179.9 op/s
Target 1: 1884000 op, 1796.7 ms, 1796663550.5 ns, 4026332 ticks, 953.6431 ns/op, 1048610.4 op/s
Target 2: 1884000 op, 1714.4 ms, 1714394657.8 ns, 3841967 ticks, 909.9759 ns/op, 1098930.2 op/s
Target 3: 1884000 op, 1676 ms, 1676045345.7 ns, 3756026 ticks, 889.6207 ns/op, 1124074.6 op/s
Target 4: 1884000 op, 1690.5 ms, 1690545536.5 ns, 3788521 ticks, 897.3172 ns/op, 1114433.2 op/s
Target 5: 1884000 op, 1699.5 ms, 1699488845.4 ns, 3808563 ticks, 902.0641 ns/op, 1108568.6 op/s
Target 6: 1884000 op, 1672.6 ms, 1672581274.9 ns, 3748263 ticks, 887.782 ns/op, 1126402.7 op/s
Target 7: 1884000 op, 1667.2 ms, 1667241706.3 ns, 3736297 ticks, 884.9478 ns/op, 1130010.1 op/s
Target 8: 1884000 op, 1655.7 ms, 1655661187.7 ns, 3710345 ticks, 878.8011 ns/op, 1137914 op/s
Target 9: 1884000 op, 1812.2 ms, 1812155260.7 ns, 4061049 ticks, 961.8658 ns/op, 1039646 op/s
Target 10: 1884000 op, 1779.8 ms, 1779763989.8 ns, 3988460 ticks, 944.673 ns/op, 1058567.3 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 16956.7 ns, 38 ticks, 16956.6779 ns/op, 58973.8 op/s
// Pre-Warmup: 1000 op, 1.6 ms, 1561799.3 ns, 3500 ticks, 1561.7993 ns/op, 640287.1 op/s
// Pre-Warmup: 641000 op, 614.6 ms, 614557308 ns, 1377226 ticks, 958.7478 ns/op, 1043027.2 op/s
// Pre-Warmup: 1282000 op, 1200.4 ms, 1200398928.2 ns, 2690100 ticks, 936.3486 ns/op, 1067978.3 op/s
// Warmup (idle): 1282000 op, 3.8 ms, 3848719.7 ns, 8625 ticks, 3.0021 ns/op, 333097786.7 op/s
// Warmup (idle): 1282000 op, 3.7 ms, 3663088.7 ns, 8209 ticks, 2.8573 ns/op, 349977879.2 op/s
// Warmup (idle): 1282000 op, 3.7 ms, 3672905.7 ns, 8231 ticks, 2.865 ns/op, 349042450.5 op/s
// IterationCount = 1282000
// Target (idle): 1282000 op, 3.9 ms, 3907621.8 ns, 8757 ticks, 3.0481 ns/op, 328076785.4 op/s
// Target (idle): 1282000 op, 3.8 ms, 3802311.9 ns, 8521 ticks, 2.9659 ns/op, 337163291.9 op/s
// Target (idle): 1282000 op, 3.7 ms, 3692093.5 ns, 8274 ticks, 2.8799 ns/op, 347228475.9 op/s
// Target (idle): 1282000 op, 3.7 ms, 3674690.6 ns, 8235 ticks, 2.8664 ns/op, 348872909.5 op/s
// Target (idle): 1282000 op, 3.7 ms, 3719759.7 ns, 8336 ticks, 2.9015 ns/op, 344645922.5 op/s
// Warmup 1: 1282000 op, 1212.6 ms, 1212613983.5 ns, 2717474 ticks, 945.8767 ns/op, 1057220.2 op/s
// Warmup 2: 1282000 op, 1203.4 ms, 1203384642.2 ns, 2696791 ticks, 938.6776 ns/op, 1065328.5 op/s
// Warmup 3: 1282000 op, 1192.8 ms, 1192790288.3 ns, 2673049 ticks, 930.4136 ns/op, 1074790.8 op/s
// Warmup 4: 1282000 op, 1215.9 ms, 1215948201.8 ns, 2724946 ticks, 948.4775 ns/op, 1054321.2 op/s
// Warmup 5: 1282000 op, 1150.3 ms, 1150332997.9 ns, 2577902 ticks, 897.2956 ns/op, 1114459.9 op/s
Target 1: 1282000 op, 1125.9 ms, 1125854248.4 ns, 2523045 ticks, 878.2014 ns/op, 1138690.9 op/s
Target 2: 1282000 op, 1132.4 ms, 1132412020.5 ns, 2537741 ticks, 883.3167 ns/op, 1132096.8 op/s
Target 3: 1282000 op, 1121.7 ms, 1121673534.9 ns, 2513676 ticks, 874.9404 ns/op, 1142935.1 op/s
Target 4: 1282000 op, 1205.7 ms, 1205721986.3 ns, 2702029 ticks, 940.5008 ns/op, 1063263.4 op/s
Target 5: 1282000 op, 1205.3 ms, 1205329305.4 ns, 2701149 ticks, 940.1945 ns/op, 1063609.7 op/s
Target 6: 1282000 op, 1212.4 ms, 1212447094 ns, 2717100 ticks, 945.7466 ns/op, 1057365.7 op/s
Target 7: 1282000 op, 1212.3 ms, 1212277973.5 ns, 2716721 ticks, 945.6146 ns/op, 1057513.2 op/s
Target 8: 1282000 op, 1209.9 ms, 1209889313.1 ns, 2711368 ticks, 943.7514 ns/op, 1059601.1 op/s
Target 9: 1282000 op, 1201.3 ms, 1201318158.6 ns, 2692160 ticks, 937.0656 ns/op, 1067161.1 op/s
Target 10: 1282000 op, 1221.6 ms, 1221586297.2 ns, 2737581 ticks, 952.8754 ns/op, 1049455.1 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 19187.8 ns, 43 ticks, 19187.8198 ns/op, 52116.4 op/s
// Pre-Warmup: 1000 op, 2.8 ms, 2796513.2 ns, 6267 ticks, 2796.5132 ns/op, 357588.2 op/s
// Pre-Warmup: 358000 op, 351.7 ms, 351656065 ns, 788063 ticks, 982.2795 ns/op, 1018040.2 op/s
// Pre-Warmup: 1074000 op, 1000.5 ms, 1000530565.5 ns, 2242194 ticks, 931.5927 ns/op, 1073430.5 op/s
// Warmup (idle): 1074000 op, 3.1 ms, 3089239 ns, 6923 ticks, 2.8764 ns/op, 347658438.5 op/s
// Warmup (idle): 1074000 op, 3.6 ms, 3585444.9 ns, 8035 ticks, 3.3384 ns/op, 299544414.4 op/s
// Warmup (idle): 1074000 op, 3.5 ms, 3510924.8 ns, 7868 ticks, 3.269 ns/op, 305902309.4 op/s
// IterationCount = 1077231
// Target (idle): 1077231 op, 3.5 ms, 3496645.5 ns, 7836 ticks, 3.246 ns/op, 308075556 op/s
// Target (idle): 1077231 op, 3.3 ms, 3265499.2 ns, 7318 ticks, 3.0314 ns/op, 329882489.4 op/s
// Target (idle): 1077231 op, 3.6 ms, 3605971.4 ns, 8081 ticks, 3.3474 ns/op, 298735312.1 op/s
// Target (idle): 1077231 op, 3.7 ms, 3658180.1 ns, 8198 ticks, 3.3959 ns/op, 294471829.4 op/s
// Target (idle): 1077231 op, 3.1 ms, 3116458.9 ns, 6984 ticks, 2.893 ns/op, 345658656.5 op/s
// Warmup 1: 1077231 op, 1034.2 ms, 1034151641.8 ns, 2317539 ticks, 960.0092 ns/op, 1041656.7 op/s
// Warmup 2: 1077231 op, 996.2 ms, 996183855 ns, 2232453 ticks, 924.7634 ns/op, 1081357.6 op/s
// Warmup 3: 1077231 op, 943.7 ms, 943671254.6 ns, 2114772 ticks, 876.0157 ns/op, 1141532.1 op/s
// Warmup 4: 1077231 op, 961.1 ms, 961123692.3 ns, 2153883 ticks, 892.2169 ns/op, 1120803.7 op/s
// Warmup 5: 1077231 op, 964.7 ms, 964683255.9 ns, 2161860 ticks, 895.5213 ns/op, 1116668.1 op/s
Target 1: 1077231 op, 964.2 ms, 964233011.5 ns, 2160851 ticks, 895.1033 ns/op, 1117189.5 op/s
Target 2: 1077231 op, 956.4 ms, 956425800 ns, 2143355 ticks, 887.8558 ns/op, 1126309 op/s
Target 3: 1077231 op, 1033.8 ms, 1033831696 ns, 2316822 ticks, 959.7122 ns/op, 1041979.1 op/s
Target 4: 1077231 op, 1010 ms, 1010016488.1 ns, 2263452 ticks, 937.6044 ns/op, 1066547.9 op/s
Target 5: 1077231 op, 1007.9 ms, 1007865667.4 ns, 2258632 ticks, 935.6077 ns/op, 1068824 op/s
Target 6: 1077231 op, 1020.4 ms, 1020399329.8 ns, 2286720 ticks, 947.2428 ns/op, 1055695.5 op/s
Target 7: 1077231 op, 1038.7 ms, 1038696923.9 ns, 2327725 ticks, 964.2286 ns/op, 1037098.5 op/s
Target 8: 1077231 op, 1123.1 ms, 1123069783.4 ns, 2516805 ticks, 1042.5524 ns/op, 959184.4 op/s
Target 9: 1077231 op, 952.6 ms, 952636875 ns, 2134864 ticks, 884.3385 ns/op, 1130788.7 op/s
Target 10: 1077231 op, 947 ms, 946951033.1 ns, 2122122 ticks, 879.0603 ns/op, 1137578.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=922.873474151119 +- 13.7352088722694
OperationsPerSecond: Avr=1085334.80031065 +- 15715.4321160804

// **************************
// Benchmark: ComparisonTest_ReflectionCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0.2 ms, 207496.2 ns, 465 ticks, 207496.1903 ns/op, 4819.4 op/s
// Pre-Warmup: 1000 op, 40.8 ms, 40833465.3 ns, 91508 ticks, 40833.4653 ns/op, 24489.7 op/s
// Pre-Warmup: 25000 op, 802.9 ms, 802896468.3 ns, 1799295 ticks, 32115.8587 ns/op, 31137.3 op/s
// Pre-Warmup: 50000 op, 1574.9 ms, 1574873326.9 ns, 3529299 ticks, 31497.4665 ns/op, 31748.6 op/s
// Warmup (idle): 50000 op, 0.2 ms, 151717.6 ns, 340 ticks, 3.0344 ns/op, 329559558.8 op/s
// Warmup (idle): 50000 op, 0.2 ms, 152610.1 ns, 342 ticks, 3.0522 ns/op, 327632309.9 op/s
// Warmup (idle): 50000 op, 0.1 ms, 149932.7 ns, 336 ticks, 2.9987 ns/op, 333482886.9 op/s
// IterationCount = 50000
// Target (idle): 50000 op, 0.1 ms, 149932.7 ns, 336 ticks, 2.9987 ns/op, 333482886.9 op/s
// Target (idle): 50000 op, 0.2 ms, 161980.9 ns, 363 ticks, 3.2396 ns/op, 308678374.7 op/s
// Target (idle): 50000 op, 0.2 ms, 170905.5 ns, 383 ticks, 3.4181 ns/op, 292559399.5 op/s
// Target (idle): 50000 op, 0.2 ms, 173136.6 ns, 388 ticks, 3.4627 ns/op, 288789304.1 op/s
// Target (idle): 50000 op, 0.2 ms, 160196 ns, 359 ticks, 3.2039 ns/op, 312117688 op/s
// Warmup 1: 50000 op, 1438 ms, 1438015979.4 ns, 3222601 ticks, 28760.3196 ns/op, 34770.1 op/s
// Warmup 2: 50000 op, 1475 ms, 1474950747.5 ns, 3305372 ticks, 29499.015 ns/op, 33899.4 op/s
// Warmup 3: 50000 op, 1439.5 ms, 1439456404.6 ns, 3225829 ticks, 28789.1281 ns/op, 34735.3 op/s
// Warmup 4: 50000 op, 1556.4 ms, 1556449003.9 ns, 3488010 ticks, 31128.9801 ns/op, 32124.4 op/s
// Warmup 5: 50000 op, 1488.9 ms, 1488894491.5 ns, 3336620 ticks, 29777.8898 ns/op, 33582 op/s
Target 1: 50000 op, 1460.1 ms, 1460082418.4 ns, 3272052 ticks, 29201.6484 ns/op, 34244.6 op/s
Target 2: 50000 op, 1577.7 ms, 1577697952.5 ns, 3535629 ticks, 31553.959 ns/op, 31691.7 op/s
Target 3: 50000 op, 1636 ms, 1635956189.3 ns, 3666186 ticks, 32719.1238 ns/op, 30563.2 op/s
Target 4: 50000 op, 1647.8 ms, 1647821401.6 ns, 3692776 ticks, 32956.428 ns/op, 30343.1 op/s
Target 5: 50000 op, 1620.6 ms, 1620644755.4 ns, 3631873 ticks, 32412.8951 ns/op, 30851.9 op/s
Target 6: 50000 op, 1652.9 ms, 1652911974.8 ns, 3704184 ticks, 33058.2395 ns/op, 30249.6 op/s
Target 7: 50000 op, 1624 ms, 1624024935.2 ns, 3639448 ticks, 32480.4987 ns/op, 30787.7 op/s
Target 8: 50000 op, 1601.2 ms, 1601232929 ns, 3588371 ticks, 32024.6586 ns/op, 31225.9 op/s
Target 9: 50000 op, 1628 ms, 1627957992.1 ns, 3648262 ticks, 32559.1598 ns/op, 30713.3 op/s
Target 10: 50000 op, 1738.8 ms, 1738767204.9 ns, 3896586 ticks, 34775.3441 ns/op, 28756 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0.1 ms, 91030.6 ns, 204 ticks, 91030.5867 ns/op, 10985.3 op/s
// Pre-Warmup: 1000 op, 40.6 ms, 40621953.1 ns, 91034 ticks, 40621.9531 ns/op, 24617.2 op/s
// Pre-Warmup: 25000 op, 849.6 ms, 849607653.7 ns, 1903975 ticks, 33984.3061 ns/op, 29425.3 op/s
// Pre-Warmup: 50000 op, 1505.3 ms, 1505325066.2 ns, 3373441 ticks, 30106.5013 ns/op, 33215.4 op/s
// Warmup (idle): 50000 op, 0.1 ms, 141008.2 ns, 316 ticks, 2.8202 ns/op, 354589398.7 op/s
// Warmup (idle): 50000 op, 0.2 ms, 161088.4 ns, 361 ticks, 3.2218 ns/op, 310388504.2 op/s
// Warmup (idle): 50000 op, 0.2 ms, 151271.4 ns, 339 ticks, 3.0254 ns/op, 330531710.9 op/s
// IterationCount = 50000
// Target (idle): 50000 op, 0.2 ms, 186969.7 ns, 419 ticks, 3.7394 ns/op, 267423031 op/s
// Target (idle): 50000 op, 0.2 ms, 154841.2 ns, 347 ticks, 3.0968 ns/op, 322911383.3 op/s
// Target (idle): 50000 op, 0.1 ms, 148594 ns, 333 ticks, 2.9719 ns/op, 336487237.2 op/s
// Target (idle): 50000 op, 0.1 ms, 149486.5 ns, 335 ticks, 2.9897 ns/op, 334478358.2 op/s
// Target (idle): 50000 op, 0.1 ms, 148594 ns, 333 ticks, 2.9719 ns/op, 336487237.2 op/s
// Warmup 1: 50000 op, 1523.3 ms, 1523252290.8 ns, 3413616 ticks, 30465.0458 ns/op, 32824.5 op/s
// Warmup 2: 50000 op, 1513 ms, 1512959587.3 ns, 3390550 ticks, 30259.1917 ns/op, 33047.8 op/s
// Warmup 3: 50000 op, 1513.1 ms, 1513060434.9 ns, 3390776 ticks, 30261.2087 ns/op, 33045.6 op/s
// Warmup 4: 50000 op, 1497.8 ms, 1497815935.3 ns, 3356613 ticks, 29956.3187 ns/op, 33381.9 op/s
// Warmup 5: 50000 op, 1638.9 ms, 1638900850.3 ns, 3672785 ticks, 32778.017 ns/op, 30508.3 op/s
Target 1: 50000 op, 1645.6 ms, 1645606770.2 ns, 3687813 ticks, 32912.1354 ns/op, 30383.9 op/s
Target 2: 50000 op, 1697.2 ms, 1697191661.8 ns, 3803415 ticks, 33943.8332 ns/op, 29460.4 op/s
Target 3: 50000 op, 1672.9 ms, 1672892742.3 ns, 3748961 ticks, 33457.8548 ns/op, 29888.3 op/s
Target 4: 50000 op, 1658 ms, 1657972204.4 ns, 3715524 ticks, 33159.4441 ns/op, 30157.3 op/s
Target 5: 50000 op, 1508 ms, 1508049290.4 ns, 3379546 ticks, 30160.9858 ns/op, 33155.4 op/s
Target 6: 50000 op, 1502.6 ms, 1502568713.6 ns, 3367264 ticks, 30051.3743 ns/op, 33276.3 op/s
Target 7: 50000 op, 1516.7 ms, 1516652573.3 ns, 3398826 ticks, 30333.0515 ns/op, 32967.3 op/s
Target 8: 50000 op, 1636.1 ms, 1636130218.4 ns, 3666576 ticks, 32722.6044 ns/op, 30559.9 op/s
Target 9: 50000 op, 1679.4 ms, 1679410800.1 ns, 3763568 ticks, 33588.216 ns/op, 29772.3 op/s
Target 10: 50000 op, 1688.5 ms, 1688471020.8 ns, 3783872 ticks, 33769.4204 ns/op, 29612.6 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0.1 ms, 95046.6 ns, 213 ticks, 95046.642 ns/op, 10521.2 op/s
// Pre-Warmup: 1000 op, 31.9 ms, 31886140.4 ns, 71457 ticks, 31886.1404 ns/op, 31361.6 op/s
// Pre-Warmup: 32000 op, 1090.8 ms, 1090772666.7 ns, 2444427 ticks, 34086.6458 ns/op, 29337 op/s
// Warmup (idle): 32000 op, 0.1 ms, 97724 ns, 219 ticks, 3.0539 ns/op, 327452785.4 op/s
// Warmup (idle): 32000 op, 0.1 ms, 98170.2 ns, 220 ticks, 3.0678 ns/op, 325964363.6 op/s
// Warmup (idle): 32000 op, 0.1 ms, 114680.7 ns, 257 ticks, 3.5838 ns/op, 279035642 op/s
// IterationCount = 32000
// Target (idle): 32000 op, 0.1 ms, 95046.6 ns, 213 ticks, 2.9702 ns/op, 336676807.5 op/s
// Target (idle): 32000 op, 0.1 ms, 106202.4 ns, 238 ticks, 3.3188 ns/op, 301311596.6 op/s
// Target (idle): 32000 op, 0.1 ms, 107094.8 ns, 240 ticks, 3.3467 ns/op, 298800666.7 op/s
// Target (idle): 32000 op, 0.1 ms, 99062.7 ns, 222 ticks, 3.0957 ns/op, 323027747.7 op/s
// Target (idle): 32000 op, 0.1 ms, 101740.1 ns, 228 ticks, 3.1794 ns/op, 314527017.5 op/s
// Warmup 1: 32000 op, 1044.9 ms, 1044945906 ns, 2341729 ticks, 32654.5596 ns/op, 30623.6 op/s
// Warmup 2: 32000 op, 974.4 ms, 974447625.1 ns, 2183742 ticks, 30451.4883 ns/op, 32839.1 op/s
// Warmup 3: 32000 op, 934.7 ms, 934736870.3 ns, 2094750 ticks, 29210.5272 ns/op, 34234.2 op/s
// Warmup 4: 32000 op, 945.6 ms, 945571295 ns, 2119030 ticks, 29549.103 ns/op, 33842 op/s
// Warmup 5: 32000 op, 941.8 ms, 941825654.1 ns, 2110636 ticks, 29432.0517 ns/op, 33976.6 op/s
Target 1: 32000 op, 939.1 ms, 939135789.5 ns, 2104608 ticks, 29347.9934 ns/op, 34073.9 op/s
Target 2: 32000 op, 941.4 ms, 941374071 ns, 2109624 ticks, 29417.9397 ns/op, 33992.9 op/s
Target 3: 32000 op, 1017.9 ms, 1017850919.6 ns, 2281009 ticks, 31807.8412 ns/op, 31438.8 op/s
Target 4: 32000 op, 1026.8 ms, 1026824125.8 ns, 2301118 ticks, 32088.2539 ns/op, 31164.1 op/s
Target 5: 32000 op, 1060.8 ms, 1060761131.7 ns, 2377171 ticks, 33148.7854 ns/op, 30167 op/s
Target 6: 32000 op, 1056.4 ms, 1056449227 ns, 2367508 ticks, 33014.0383 ns/op, 30290.1 op/s
Target 7: 32000 op, 949.9 ms, 949880522.4 ns, 2128687 ticks, 29683.7663 ns/op, 33688.4 op/s
Target 8: 32000 op, 949.6 ms, 949562807.8 ns, 2127975 ticks, 29673.8377 ns/op, 33699.7 op/s
Target 9: 32000 op, 940.7 ms, 940732840.8 ns, 2108187 ticks, 29397.9013 ns/op, 34016 op/s
Target 10: 32000 op, 941.5 ms, 941475811.1 ns, 2109852 ticks, 29421.1191 ns/op, 33989.2 op/s
// Benchmark finished

AverageTime (ns/op): Avr=31828.0783809792 +- 603.987290527938
OperationsPerSecond: Avr=31506.0433755415 +- 609.517220258604

// ***** Competition: Finish  *****

```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=ComparisonTest  Mode=Throughput  .NET=HostFramework  
```

            Method | Platform |       Jit |        AvrTime |        StdDev |         op/s |
------------------ |--------- |---------- |--------------- |-------------- |------------- |
     ManualCompare |      X64 | LegacyJit |  1,364.3835 ns |    47.6975 ns |   732,941.68 |
 ReflectionCompare |      X64 | LegacyJit | 36,779.9097 ns | 3,080.9738 ns |    27,188.92 |
     ManualCompare |      X64 |    RyuJit |    930.8761 ns |    43.6018 ns | 1,074,294.12 |
 ReflectionCompare |      X64 |    RyuJit | 36,909.7334 ns | 3,762.0698 ns |    27,093.98 |
     ManualCompare |      X86 | LegacyJit |    936.3367 ns |    38.3831 ns | 1,067,992.54 |
 ReflectionCompare |      X86 | LegacyJit | 32,446.6969 ns | 1,687.8442 ns |    30,819.81 |

// ***** Competition: End *****
```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=ComparisonTest  Mode=Throughput  .NET=HostFramework  
```

            Method | Platform |   