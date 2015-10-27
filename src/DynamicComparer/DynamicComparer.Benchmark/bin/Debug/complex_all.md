// ***** Competition: Start   *****
// Found benchmarks:
//   ComplexComparisonTest_DynamicCodeCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_DynamicCodeCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_DynamicCodeCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10
//   ComplexComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework -w=5 -t=10

// **************************
// Benchmark: ComplexComparisonTest_DynamicCodeCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_DynamicCodeCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 35252.1 ns, 79 ticks, 35252.0567 ns/op, 28367.1 op/s
// Pre-Warmup: 1000 op, 1.1 ms, 1072287.2 ns, 2403 ticks, 1072.2872 ns/op, 932585.9 op/s
// Pre-Warmup: 933000 op, 1031.4 ms, 1031383255 ns, 2311334 ticks, 1105.4483 ns/op, 904610.4 op/s
// Warmup (idle): 933000 op, 2.9 ms, 2867911 ns, 6427 ticks, 3.0739 ns/op, 325323904.2 op/s
// Warmup (idle): 933000 op, 2.8 ms, 2775095.4 ns, 6219 ticks, 2.9744 ns/op, 336204652.2 op/s
// Warmup (idle): 933000 op, 2.8 ms, 2775987.9 ns, 6221 ticks, 2.9753 ns/op, 336096565.2 op/s
// IterationCount = 933000
// Target (idle): 933000 op, 2.9 ms, 2946001 ns, 6602 ticks, 3.1576 ns/op, 316700504.7 op/s
// Target (idle): 933000 op, 3 ms, 3001333.3 ns, 6726 ticks, 3.2169 ns/op, 310861839.4 op/s
// Target (idle): 933000 op, 2.8 ms, 2828642.9 ns, 6339 ticks, 3.0318 ns/op, 329840153.3 op/s
// Target (idle): 933000 op, 2.8 ms, 2773756.8 ns, 6216 ticks, 2.9729 ns/op, 336366913.1 op/s
// Target (idle): 933000 op, 2.8 ms, 2774203 ns, 6217 ticks, 2.9734 ns/op, 336312808.8 op/s
// Warmup 1: 933000 op, 961.4 ms, 961380702.6 ns, 2154458 ticks, 1030.4188 ns/op, 970479.2 op/s
// Warmup 2: 933000 op, 962.4 ms, 962416399.1 ns, 2156779 ticks, 1031.5288 ns/op, 969434.9 op/s
// Warmup 3: 933000 op, 964.4 ms, 964422196.5 ns, 2161274 ticks, 1033.6787 ns/op, 967418.6 op/s
// Warmup 4: 933000 op, 981.5 ms, 981515427.9 ns, 2199580 ticks, 1051.9994 ns/op, 950570.9 op/s
// Warmup 5: 933000 op, 1096.6 ms, 1096550474.7 ns, 2457374 ticks, 1175.2953 ns/op, 850850 op/s
Target 1: 933000 op, 1102 ms, 1102032838.9 ns, 2469660 ticks, 1181.1713 ns/op, 846617.2 op/s
Target 2: 933000 op, 1030.4 ms, 1030387272.8 ns, 2309102 ticks, 1104.3808 ns/op, 905484.8 op/s
Target 3: 933000 op, 1027.1 ms, 1027135159.1 ns, 2301814 ticks, 1100.8951 ns/op, 908351.7 op/s
Target 4: 933000 op, 1028.4 ms, 1028390846.2 ns, 2304628 ticks, 1102.241 ns/op, 907242.6 op/s
Target 5: 933000 op, 1037.3 ms, 1037269456 ns, 2324525 ticks, 1111.7572 ns/op, 899477 op/s
Target 6: 933000 op, 1022.3 ms, 1022309197.1 ns, 2290999 ticks, 1095.7226 ns/op, 912639.7 op/s
Target 7: 933000 op, 1016.1 ms, 1016063782.1 ns, 2277003 ticks, 1089.0287 ns/op, 918249.4 op/s
Target 8: 933000 op, 1048.2 ms, 1048228383.3 ns, 2349084 ticks, 1123.5031 ns/op, 890073.2 op/s
Target 9: 933000 op, 1057.7 ms, 1057737960.3 ns, 2370395 ticks, 1133.6956 ns/op, 882071 op/s
Target 10: 933000 op, 1034.3 ms, 1034301589.8 ns, 2317874 ticks, 1108.5762 ns/op, 902058 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 33467.1 ns, 75 ticks, 33467.1424 ns/op, 29880.1 op/s
// Pre-Warmup: 1000 op, 1 ms, 1006691.6 ns, 2256 ticks, 1006.6916 ns/op, 993352.8 op/s
// Pre-Warmup: 994000 op, 1107.2 ms, 1107160897.5 ns, 2481152 ticks, 1113.844 ns/op, 897791.8 op/s
// Warmup (idle): 994000 op, 2.9 ms, 2907179.1 ns, 6515 ticks, 2.9247 ns/op, 341912198.9 op/s
// Warmup (idle): 994000 op, 3.1 ms, 3068267.6 ns, 6876 ticks, 3.0868 ns/op, 323961311.2 op/s
// Warmup (idle): 994000 op, 3 ms, 3004903.2 ns, 6734 ticks, 3.023 ns/op, 330792690.2 op/s
// IterationCount = 994000
// Target (idle): 994000 op, 2.9 ms, 2911641.4 ns, 6525 ticks, 2.9292 ns/op, 341388195.6 op/s
// Target (idle): 994000 op, 2.8 ms, 2794283.3 ns, 6262 ticks, 2.8112 ns/op, 355726281.7 op/s
// Target (idle): 994000 op, 2.9 ms, 2896023.4 ns, 6490 ticks, 2.9135 ns/op, 343229272.1 op/s
// Target (idle): 994000 op, 3 ms, 3012042.8 ns, 6750 ticks, 3.0302 ns/op, 330008589 op/s
// Target (idle): 994000 op, 3 ms, 2986607.8 ns, 6693 ticks, 3.0046 ns/op, 332819061.1 op/s
// Warmup 1: 994000 op, 1101.5 ms, 1101468359.7 ns, 2468395 ticks, 1108.1171 ns/op, 902431.7 op/s
// Warmup 2: 994000 op, 1120.7 ms, 1120717767.6 ns, 2511533 ticks, 1127.4827 ns/op, 886931.6 op/s
// Warmup 3: 994000 op, 1083.1 ms, 1083092221.2 ns, 2427214 ticks, 1089.63 ns/op, 917742.7 op/s
// Warmup 4: 994000 op, 1112.3 ms, 1112327778.1 ns, 2492731 ticks, 1119.042 ns/op, 893621.5 op/s
// Warmup 5: 994000 op, 1099.4 ms, 1099427756.5 ns, 2463822 ticks, 1106.0641 ns/op, 904106.7 op/s
Target 1: 994000 op, 1104.9 ms, 1104912351.8 ns, 2476113 ticks, 1111.5818 ns/op, 899618.9 op/s
Target 2: 994000 op, 1112.3 ms, 1112296542.1 ns, 2492661 ticks, 1119.0106 ns/op, 893646.6 op/s
Target 3: 994000 op, 1103.5 ms, 1103512979 ns, 2472977 ticks, 1110.174 ns/op, 900759.7 op/s
Target 4: 994000 op, 1099.4 ms, 1099385811 ns, 2463728 ticks, 1106.0219 ns/op, 904141.2 op/s
Target 5: 994000 op, 1091.2 ms, 1091206887.6 ns, 2445399 ticks, 1097.7936 ns/op, 910918 op/s
Target 6: 994000 op, 1103.9 ms, 1103927525.3 ns, 2473906 ticks, 1110.5911 ns/op, 900421.4 op/s
Target 7: 994000 op, 1136.9 ms, 1136873919 ns, 2547739 ticks, 1143.7363 ns/op, 874327.4 op/s
Target 8: 994000 op, 1091.5 ms, 1091546467.6 ns, 2446160 ticks, 1098.1353 ns/op, 910634.6 op/s
Target 9: 994000 op, 1143.2 ms, 1143168419.2 ns, 2561845 ticks, 1150.0688 ns/op, 869513.2 op/s
Target 10: 994000 op, 1068.9 ms, 1068886534.8 ns, 2395379 ticks, 1075.3386 ns/op, 929939.7 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 27666.2 ns, 62 ticks, 27666.1711 ns/op, 36145.2 op/s
// Pre-Warmup: 1000 op, 1 ms, 999105.8 ns, 2239 ticks, 999.1058 ns/op, 1000895 op/s
// Pre-Warmup: 1000000 op, 1089.8 ms, 1089795912.9 ns, 2442237 ticks, 1089.7959 ns/op, 917603 op/s
// Warmup (idle): 1000000 op, 3.1 ms, 3085670.5 ns, 6915 ticks, 3.0857 ns/op, 324078669.6 op/s
// Warmup (idle): 1000000 op, 2.8 ms, 2820610.8 ns, 6321 ticks, 2.8206 ns/op, 354533143.5 op/s
// Warmup (idle): 1000000 op, 3 ms, 3037477.8 ns, 6807 ticks, 3.0375 ns/op, 329220508.3 op/s
// IterationCount = 1000000
// Target (idle): 1000000 op, 3.3 ms, 3303430.1 ns, 7403 ticks, 3.3034 ns/op, 302715655.8 op/s
// Target (idle): 1000000 op, 3.1 ms, 3127616 ns, 7009 ticks, 3.1276 ns/op, 319732344.1 op/s
// Target (idle): 1000000 op, 3.1 ms, 3096826.2 ns, 6940 ticks, 3.0968 ns/op, 322911239.2 op/s
// Target (idle): 1000000 op, 3.1 ms, 3110213.1 ns, 6970 ticks, 3.1102 ns/op, 321521377.3 op/s
// Target (idle): 1000000 op, 2.9 ms, 2942877.4 ns, 6595 ticks, 2.9429 ns/op, 339803487.5 op/s
// Warmup 1: 1000000 op, 1095.6 ms, 1095602239 ns, 2455249 ticks, 1095.6022 ns/op, 912740 op/s
// Warmup 2: 1000000 op, 1125.1 ms, 1125100178.3 ns, 2521354 ticks, 1125.1002 ns/op, 888809.7 op/s
// Warmup 3: 1000000 op, 1282.9 ms, 1282915157.7 ns, 2875018 ticks, 1282.9152 ns/op, 779474.8 op/s
// Warmup 4: 1000000 op, 1250.3 ms, 1250251226.7 ns, 2801818 ticks, 1250.2512 ns/op, 799839.2 op/s
// Warmup 5: 1000000 op, 1239.4 ms, 1239434200 ns, 2777577 ticks, 1239.4342 ns/op, 806819.8 op/s
Target 1: 1000000 op, 1150.1 ms, 1150050602.3 ns, 2577268 ticks, 1150.0506 ns/op, 869527 op/s
Target 2: 1000000 op, 1075.8 ms, 1075783889.7 ns, 2410836 ticks, 1075.7839 ns/op, 929554.7 op/s
Target 3: 1000000 op, 1022.3 ms, 1022273945.1 ns, 2290920 ticks, 1022.2739 ns/op, 978211.4 op/s
Target 4: 1000000 op, 1025.7 ms, 1025654572.7 ns, 2298496 ticks, 1025.6546 ns/op, 974987.1 op/s
Target 5: 1000000 op, 1105.1 ms, 1105050236.4 ns, 2476422 ticks, 1105.0502 ns/op, 904936.2 op/s
Target 6: 1000000 op, 1097.2 ms, 1097234543.1 ns, 2458907 ticks, 1097.2345 ns/op, 911382.2 op/s
Target 7: 1000000 op, 1088.8 ms, 1088759770.2 ns, 2439915 ticks, 1088.7598 ns/op, 918476.3 op/s
Target 8: 1000000 op, 1097.5 ms, 1097518790.7 ns, 2459544 ticks, 1097.5188 ns/op, 911146.1 op/s
Target 9: 1000000 op, 1158.9 ms, 1158876110.9 ns, 2597046 ticks, 1158.8761 ns/op, 862905 op/s
Target 10: 1000000 op, 1098.9 ms, 1098922625.8 ns, 2462690 ticks, 1098.9226 ns/op, 909982.2 op/s
// Benchmark finished

AverageTime (ns/op): Avr=1106.45162729222 +- 11.7900702227799
OperationsPerSecond: Avr=904576.450219197 +- 9789.63342179382

// **************************
// Benchmark: ComplexComparisonTest_ManualCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_ManualCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 23203.9 ns, 52 ticks, 23203.8854 ns/op, 43096.2 op/s
// Pre-Warmup: 1000 op, 1.4 ms, 1434178.6 ns, 3214 ticks, 1434.1786 ns/op, 697263.2 op/s
// Pre-Warmup: 698000 op, 967.2 ms, 967189706 ns, 2167476 ticks, 1385.6586 ns/op, 721678.5 op/s
// Pre-Warmup: 1396000 op, 1914.1 ms, 1914127774.9 ns, 4289568 ticks, 1371.1517 ns/op, 729313.9 op/s
// Warmup (idle): 1396000 op, 4.2 ms, 4209274.1 ns, 9433 ticks, 3.0152 ns/op, 331648636.1 op/s
// Warmup (idle): 1396000 op, 4 ms, 3989729.6 ns, 8941 ticks, 2.858 ns/op, 349898398.8 op/s
// Warmup (idle): 1396000 op, 4.1 ms, 4081206.5 ns, 9146 ticks, 2.9235 ns/op, 342055716.6 op/s
// IterationCount = 1396000
// Target (idle): 1396000 op, 3.9 ms, 3946445.4 ns, 8844 ticks, 2.827 ns/op, 353736045.2 op/s
// Target (idle): 1396000 op, 4.2 ms, 4194548.5 ns, 9400 ticks, 3.0047 ns/op, 332812934.5 op/s
// Target (idle): 1396000 op, 4.2 ms, 4170005.9 ns, 9345 ticks, 2.9871 ns/op, 334771705.1 op/s
// Target (idle): 1396000 op, 4 ms, 4037922.3 ns, 9049 ticks, 2.8925 ns/op, 345722354.3 op/s
// Target (idle): 1396000 op, 3.9 ms, 3913870.7 ns, 8771 ticks, 2.8036 ns/op, 356680148.7 op/s
// Warmup 1: 1396000 op, 1890.4 ms, 1890421436.1 ns, 4236442 ticks, 1354.1701 ns/op, 738459.7 op/s
// Warmup 2: 1396000 op, 1894.2 ms, 1894170202.3 ns, 4244843 ticks, 1356.8554 ns/op, 736998.2 op/s
// Warmup 3: 1396000 op, 1807.1 ms, 1807121718.7 ns, 4049767 ticks, 1294.4998 ns/op, 772499.2 op/s
// Warmup 4: 1396000 op, 1800.7 ms, 1800728602 ns, 4035440 ticks, 1289.9202 ns/op, 775241.8 op/s
// Warmup 5: 1396000 op, 1774.9 ms, 1774860285.8 ns, 3977469 ticks, 1271.3899 ns/op, 786540.8 op/s
Target 1: 1396000 op, 1909.6 ms, 1909636484.4 ns, 4279503 ticks, 1367.9344 ns/op, 731029.2 op/s
Target 2: 1396000 op, 1899.8 ms, 1899778402.9 ns, 4257411 ticks, 1360.8728 ns/op, 734822.5 op/s
Target 3: 1396000 op, 1903.7 ms, 1903659252.7 ns, 4266108 ticks, 1363.6528 ns/op, 733324.5 op/s
Target 4: 1396000 op, 1919.7 ms, 1919677073.3 ns, 4302004 ticks, 1375.1268 ns/op, 727205.6 op/s
Target 5: 1396000 op, 1905.8 ms, 1905753403.4 ns, 4270801 ticks, 1365.1529 ns/op, 732518.7 op/s
Target 6: 1396000 op, 1920.7 ms, 1920735527.5 ns, 4304376 ticks, 1375.885 ns/op, 726804.9 op/s
Target 7: 1396000 op, 1906.7 ms, 1906722165.6 ns, 4272972 ticks, 1365.8468 ns/op, 732146.5 op/s
Target 8: 1396000 op, 1898.1 ms, 1898140297.8 ns, 4253740 ticks, 1359.6994 ns/op, 735456.7 op/s
Target 9: 1396000 op, 1898.3 ms, 1898255424.8 ns, 4253998 ticks, 1359.7818 ns/op, 735412.1 op/s
Target 10: 1396000 op, 1921.1 ms, 1921075553.6 ns, 4305138 ticks, 1376.1286 ns/op, 726676.3 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 16510.5 ns, 37 ticks, 16510.4569 ns/op, 60567.7 op/s
// Pre-Warmup: 1000 op, 2.2 ms, 2220433.3 ns, 4976 ticks, 2220.4333 ns/op, 450362.5 op/s
// Pre-Warmup: 451000 op, 637.2 ms, 637165752.5 ns, 1427891 ticks, 1412.7844 ns/op, 707822.1 op/s
// Pre-Warmup: 902000 op, 1244.2 ms, 1244164669.1 ns, 2788178 ticks, 1379.34 ns/op, 724984.4 op/s
// Warmup (idle): 902000 op, 2.6 ms, 2602851.2 ns, 5833 ticks, 2.8856 ns/op, 346543049.5 op/s
// Warmup (idle): 902000 op, 2.6 ms, 2601512.5 ns, 5830 ticks, 2.8842 ns/op, 346721373.6 op/s
// Warmup (idle): 902000 op, 2.6 ms, 2586787 ns, 5797 ticks, 2.8678 ns/op, 348695119.5 op/s
// IterationCount = 902000
// Target (idle): 902000 op, 2.5 ms, 2533239.6 ns, 5677 ticks, 2.8085 ns/op, 356065810.8 op/s
// Target (idle): 902000 op, 2.7 ms, 2664430.8 ns, 5971 ticks, 2.9539 ns/op, 338533848.3 op/s
// Target (idle): 902000 op, 2.7 ms, 2731365 ns, 6121 ticks, 3.0281 ns/op, 330237805.6 op/s
// Target (idle): 902000 op, 2.5 ms, 2542164.1 ns, 5697 ticks, 2.8184 ns/op, 354815799.2 op/s
// Target (idle): 902000 op, 2.6 ms, 2583663.4 ns, 5790 ticks, 2.8644 ns/op, 349116685.3 op/s
// Warmup 1: 902000 op, 1271.4 ms, 1271387735.1 ns, 2849185 ticks, 1409.5208 ns/op, 709461 op/s
// Warmup 2: 902000 op, 1268.3 ms, 1268304295.8 ns, 2842275 ticks, 1406.1023 ns/op, 711185.8 op/s
// Warmup 3: 902000 op, 1293.9 ms, 1293879886 ns, 2899590 ticks, 1434.4566 ns/op, 697128.1 op/s
// Warmup 4: 902000 op, 1266.6 ms, 1266581407.3 ns, 2838414 ticks, 1404.1922 ns/op, 712153.2 op/s
// Warmup 5: 902000 op, 1244.6 ms, 1244618037.3 ns, 2789194 ticks, 1379.8426 ns/op, 724720.3 op/s
Target 1: 902000 op, 1218.6 ms, 1218554273 ns, 2730785 ticks, 1350.9471 ns/op, 740221.4 op/s
Target 2: 902000 op, 1153.3 ms, 1153271480.1 ns, 2584486 ticks, 1278.5715 ns/op, 782122.9 op/s
Target 3: 902000 op, 1154.5 ms, 1154495038.8 ns, 2587228 ticks, 1279.928 ns/op, 781294 op/s
Target 4: 902000 op, 1157.7 ms, 1157675309.8 ns, 2594355 ticks, 1283.4538 ns/op, 779147.7 op/s
Target 5: 902000 op, 1153.9 ms, 1153860055.6 ns, 2585805 ticks, 1279.224 ns/op, 781723.9 op/s
Target 6: 902000 op, 1234.1 ms, 1234059377 ns, 2765532 ticks, 1368.1368 ns/op, 730921.1 op/s
Target 7: 902000 op, 1228.2 ms, 1228232078.1 ns, 2752473 ticks, 1361.6764 ns/op, 734388.9 op/s
Target 8: 902000 op, 1229.9 ms, 1229931762.7 ns, 2756282 ticks, 1363.5607 ns/op, 733374 op/s
Target 9: 902000 op, 1225.9 ms, 1225867959.2 ns, 2747175 ticks, 1359.0554 ns/op, 735805.2 op/s
Target 10: 902000 op, 1245.2 ms, 1245203489.2 ns, 2790506 ticks, 1380.4917 ns/op, 724379.6 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0 ms, 30343.5 ns, 68 ticks, 30343.5424 ns/op, 32955.9 op/s
// Pre-Warmup: 1000 op, 2.4 ms, 2384199.2 ns, 5343 ticks, 2384.1992 ns/op, 419428 op/s
// Pre-Warmup: 420000 op, 587.8 ms, 587807518.4 ns, 1317279 ticks, 1399.5417 ns/op, 714519.6 op/s
// Pre-Warmup: 840000 op, 1155.5 ms, 1155453091.6 ns, 2589375 ticks, 1375.5394 ns/op, 726987.5 op/s
// Warmup (idle): 840000 op, 2.3 ms, 2335114.1 ns, 5233 ticks, 2.7799 ns/op, 359725465.3 op/s
// Warmup (idle): 840000 op, 2.4 ms, 2351624.5 ns, 5270 ticks, 2.7996 ns/op, 357199878.6 op/s
// Warmup (idle): 840000 op, 2.4 ms, 2352070.8 ns, 5271 ticks, 2.8001 ns/op, 357132111.6 op/s
// IterationCount = 840000
// Target (idle): 840000 op, 2.5 ms, 2460950.5 ns, 5515 ticks, 2.9297 ns/op, 341331524.9 op/s
// Target (idle): 840000 op, 2.6 ms, 2626501.3 ns, 5886 ticks, 3.1268 ns/op, 319817084.6 op/s
// Target (idle): 840000 op, 2.4 ms, 2444440.1 ns, 5478 ticks, 2.91 ns/op, 343636977 op/s
// Target (idle): 840000 op, 2.4 ms, 2352070.8 ns, 5271 ticks, 2.8001 ns/op, 357132111.6 op/s
// Target (idle): 840000 op, 2.4 ms, 2352963.2 ns, 5273 ticks, 2.8011 ns/op, 356996654.7 op/s
// Warmup 1: 840000 op, 1140.1 ms, 1140088549.6 ns, 2554943 ticks, 1357.2483 ns/op, 736784.9 op/s
// Warmup 2: 840000 op, 1135 ms, 1135047505.5 ns, 2543646 ticks, 1351.247 ns/op, 740057.1 op/s
// Warmup 3: 840000 op, 1154.1 ms, 1154144303.2 ns, 2586442 ticks, 1373.9813 ns/op, 727811.9 op/s
// Warmup 4: 840000 op, 1140.4 ms, 1140448209.8 ns, 2555749 ticks, 1357.6764 ns/op, 736552.5 op/s
// Warmup 5: 840000 op, 1148.4 ms, 1148434808.7 ns, 2573647 ticks, 1367.1843 ns/op, 731430.3 op/s
Target 1: 840000 op, 1156.8 ms, 1156809180.2 ns, 2592414 ticks, 1377.1538 ns/op, 726135.3 op/s
Target 2: 840000 op, 1137 ms, 1136992169.6 ns, 2548004 ticks, 1353.5621 ns/op, 738791.4 op/s
Target 3: 840000 op, 1142.1 ms, 1142068912 ns, 2559381 ticks, 1359.6058 ns/op, 735507.3 op/s
Target 4: 840000 op, 1069.2 ms, 1069215405.2 ns, 2396116 ticks, 1272.8755 ns/op, 785622.8 op/s
Target 5: 840000 op, 1072.1 ms, 1072124815.5 ns, 2402636 ticks, 1276.3391 ns/op, 783490.9 op/s
Target 6: 840000 op, 1075.7 ms, 1075739713.1 ns, 2410737 ticks, 1280.6425 ns/op, 780858 op/s
Target 7: 840000 op, 1070.4 ms, 1070351056.9 ns, 2398661 ticks, 1274.2274 ns/op, 784789.2 op/s
Target 8: 840000 op, 1109.9 ms, 1109891370.1 ns, 2487271 ticks, 1321.2993 ns/op, 756830.8 op/s
Target 9: 840000 op, 1150.1 ms, 1150116197.9 ns, 2577415 ticks, 1369.1859 ns/op, 730361 op/s
Target 10: 840000 op, 1150.9 ms, 1150918963.1 ns, 2579214 ticks, 1370.1416 ns/op, 729851.6 op/s
// Benchmark finished

AverageTime (ns/op): Avr=1341.00532333043 +- 14.3031956715207
OperationsPerSecond: Avr=746367.131700198 +- 8172.0567067916

// **************************
// Benchmark: ComplexComparisonTest_ReflectionCompare (Throughput_X64_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_ReflectionCompare_Throughput_X64_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0.1 ms, 131637.4 ns, 295 ticks, 131637.4268 ns/op, 7596.6 op/s
// Pre-Warmup: 1000 op, 37.2 ms, 37174409.3 ns, 83308 ticks, 37174.4093 ns/op, 26900.2 op/s
// Pre-Warmup: 27000 op, 1031.8 ms, 1031835284.5 ns, 2312347 ticks, 38216.1216 ns/op, 26167 op/s
// Warmup (idle): 27000 op, 0.1 ms, 83444.7 ns, 187 ticks, 3.0905 ns/op, 323567422.5 op/s
// Warmup (idle): 27000 op, 0.1 ms, 83444.7 ns, 187 ticks, 3.0905 ns/op, 323567422.5 op/s
// Warmup (idle): 27000 op, 0.1 ms, 82106.1 ns, 184 ticks, 3.041 ns/op, 328842978.3 op/s
// IterationCount = 27000
// Target (idle): 27000 op, 0.1 ms, 80321.1 ns, 180 ticks, 2.9749 ns/op, 336150600 op/s
// Target (idle): 27000 op, 0.1 ms, 87460.8 ns, 196 ticks, 3.2393 ns/op, 308709734.7 op/s
// Target (idle): 27000 op, 0.1 ms, 85675.9 ns, 192 ticks, 3.1732 ns/op, 315141187.5 op/s
// Target (idle): 27000 op, 0.1 ms, 82998.5 ns, 186 ticks, 3.074 ns/op, 325307032.3 op/s
// Target (idle): 27000 op, 0.1 ms, 82552.3 ns, 185 ticks, 3.0575 ns/op, 327065448.6 op/s
// Warmup 1: 27000 op, 1051.3 ms, 1051290850 ns, 2355947 ticks, 38936.6981 ns/op, 25682.7 op/s
// Warmup 2: 27000 op, 1035.9 ms, 1035891502.2 ns, 2321437 ticks, 38366.3519 ns/op, 26064.5 op/s
// Warmup 3: 27000 op, 1068.5 ms, 1068539369 ns, 2394601 ticks, 39575.5322 ns/op, 25268.1 op/s
// Warmup 4: 27000 op, 1056.6 ms, 1056603647.3 ns, 2367853 ticks, 39133.4684 ns/op, 25553.6 op/s
// Warmup 5: 27000 op, 991.3 ms, 991319515.7 ns, 2221551 ticks, 36715.5376 ns/op, 27236.4 op/s
Target 1: 27000 op, 938.6 ms, 938648034.5 ns, 2103514 ticks, 34764.742 ns/op, 28764.8 op/s
Target 2: 27000 op, 950.8 ms, 950773849.6 ns, 2130688 ticks, 35213.8463 ns/op, 28397.9 op/s
Target 3: 27000 op, 936.4 ms, 936413768.1 ns, 2098507 ticks, 34681.9914 ns/op, 28833.4 op/s
Target 4: 27000 op, 929.6 ms, 929596288.1 ns, 2083229 ticks, 34429.4922 ns/op, 29044.9 op/s
Target 5: 27000 op, 1014 ms, 1014006668.4 ns, 2272393 ticks, 37555.8025 ns/op, 26627 op/s
Target 6: 27000 op, 1045.2 ms, 1045173502.6 ns, 2342238 ticks, 38710.1297 ns/op, 25833 op/s
Target 7: 27000 op, 983.9 ms, 983879100.6 ns, 2204877 ticks, 36439.9667 ns/op, 27442.4 op/s
Target 8: 27000 op, 938.8 ms, 938848391.2 ns, 2103963 ticks, 34772.1626 ns/op, 28758.6 op/s
Target 9: 27000 op, 934.7 ms, 934716314.7 ns, 2094703 ticks, 34619.1228 ns/op, 28885.8 op/s
Target 10: 27000 op, 937.1 ms, 937078202.4 ns, 2099996 ticks, 34706.6001 ns/op, 28813 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0.1 ms, 128960.1 ns, 289 ticks, 128960.0554 ns/op, 7754.3 op/s
// Pre-Warmup: 1000 op, 40.1 ms, 40125318.8 ns, 89921 ticks, 40125.3188 ns/op, 24921.9 op/s
// Pre-Warmup: 25000 op, 959 ms, 958995610.9 ns, 2149113 ticks, 38359.8244 ns/op, 26068.9 op/s
// Pre-Warmup: 50000 op, 1958.4 ms, 1958428008.2 ns, 4388845 ticks, 39168.5602 ns/op, 25530.7 op/s
// Warmup (idle): 50000 op, 0.2 ms, 152163.9 ns, 341 ticks, 3.0433 ns/op, 328592961.9 op/s
// Warmup (idle): 50000 op, 0.1 ms, 149486.6 ns, 335 ticks, 2.9897 ns/op, 334478209 op/s
// Warmup (idle): 50000 op, 0.1 ms, 148594.1 ns, 333 ticks, 2.9719 ns/op, 336487087.1 op/s
// IterationCount = 50000
// Target (idle): 50000 op, 0.2 ms, 191432.1 ns, 429 ticks, 3.8286 ns/op, 261189277.4 op/s
// Target (idle): 50000 op, 0.2 ms, 154841.3 ns, 347 ticks, 3.0968 ns/op, 322911239.2 op/s
// Target (idle): 50000 op, 0.2 ms, 150825.3 ns, 338 ticks, 3.0165 ns/op, 331509467.5 op/s
// Target (idle): 50000 op, 0.2 ms, 153502.6 ns, 344 ticks, 3.0701 ns/op, 325727325.6 op/s
// Target (idle): 50000 op, 0.2 ms, 152163.9 ns, 341 ticks, 3.0433 ns/op, 328592961.9 op/s
// Warmup 1: 50000 op, 2031.9 ms, 2031870982.8 ns, 4553431 ticks, 40637.4197 ns/op, 24607.9 op/s
// Warmup 2: 50000 op, 1943.4 ms, 1943446330.3 ns, 4355271 ticks, 38868.9266 ns/op, 25727.5 op/s
// Warmup 3: 50000 op, 1941 ms, 1940999659.1 ns, 4349788 ticks, 38819.9932 ns/op, 25759.9 op/s
// Warmup 4: 50000 op, 1912.2 ms, 1912218809.1 ns, 4285290 ticks, 38244.3762 ns/op, 26147.6 op/s
// Warmup 5: 50000 op, 1744.4 ms, 1744350746.4 ns, 3909097 ticks, 34887.0149 ns/op, 28664 op/s
Target 1: 50000 op, 1743.8 ms, 1743842492 ns, 3907958 ticks, 34876.8498 ns/op, 28672.3 op/s
Target 2: 50000 op, 1735.1 ms, 1735051789.3 ns, 3888258 ticks, 34701.0358 ns/op, 28817.6 op/s
Target 3: 50000 op, 1926.6 ms, 1926572197.1 ns, 4317456 ticks, 38531.4439 ns/op, 25952.8 op/s
Target 4: 50000 op, 1926.5 ms, 1926545869.6 ns, 4317397 ticks, 38530.9174 ns/op, 25953.2 op/s
Target 5: 50000 op, 1957.1 ms, 1957083521.5 ns, 4385832 ticks, 39141.6704 ns/op, 25548.2 op/s
Target 6: 50000 op, 1929 ms, 1928972014.3 ns, 4322834 ticks, 38579.4403 ns/op, 25920.5 op/s
Target 7: 50000 op, 1964.5 ms, 1964487345.9 ns, 4402424 ticks, 39289.7469 ns/op, 25451.9 op/s
Target 8: 50000 op, 1939.6 ms, 1939626167.6 ns, 4346710 ticks, 38792.5234 ns/op, 25778.2 op/s
Target 9: 50000 op, 1833 ms, 1832977540.4 ns, 4107710 ticks, 36659.5508 ns/op, 27278 op/s
Target 10: 50000 op, 1743.5 ms, 1743501127.2 ns, 3907193 ticks, 34870.0225 ns/op, 28677.9 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit 
// Pre-Warmup: 1 op, 0.1 ms, 122712.9 ns, 275 ticks, 122712.8555 ns/op, 8149.1 op/s
// Pre-Warmup: 1000 op, 41.6 ms, 41599658 ns, 93225 ticks, 41599.658 ns/op, 24038.7 op/s
// Pre-Warmup: 25000 op, 966 ms, 965952760.5 ns, 2164704 ticks, 38638.1104 ns/op, 25881.2 op/s
// Pre-Warmup: 50000 op, 1992.4 ms, 1992436872 ns, 4465059 ticks, 39848.7374 ns/op, 25094.9 op/s
// Warmup (idle): 50000 op, 0.1 ms, 141900.7 ns, 318 ticks, 2.838 ns/op, 352359119.5 op/s
// Warmup (idle): 50000 op, 0.2 ms, 151271.5 ns, 339 ticks, 3.0254 ns/op, 330531563.4 op/s
// Warmup (idle): 50000 op, 0.2 ms, 151271.5 ns, 339 ticks, 3.0254 ns/op, 330531563.4 op/s
// IterationCount = 50000
// Target (idle): 50000 op, 0.2 ms, 182953.7 ns, 410 ticks, 3.6591 ns/op, 273293170.7 op/s
// Target (idle): 50000 op, 0.1 ms, 148594.1 ns, 333 ticks, 2.9719 ns/op, 336487087.1 op/s
// Target (idle): 50000 op, 0.1 ms, 148594.1 ns, 333 ticks, 2.9719 ns/op, 336487087.1 op/s
// Target (idle): 50000 op, 0.1 ms, 149932.8 ns, 336 ticks, 2.9987 ns/op, 333482738.1 op/s
// Target (idle): 50000 op, 0.1 ms, 148594.1 ns, 333 ticks, 2.9719 ns/op, 336487087.1 op/s
// Warmup 1: 50000 op, 1959.3 ms, 1959319126.6 ns, 4390842 ticks, 39186.3825 ns/op, 25519.1 op/s
// Warmup 2: 50000 op, 1940.1 ms, 1940062132.9 ns, 4347687 ticks, 38801.2427 ns/op, 25772.4 op/s
// Warmup 3: 50000 op, 1971.1 ms, 1971072787 ns, 4417182 ticks, 39421.4557 ns/op, 25366.9 op/s
// Warmup 4: 50000 op, 1977.3 ms, 1977260638.5 ns, 4431049 ticks, 39545.2128 ns/op, 25287.5 op/s
// Warmup 5: 50000 op, 1805.2 ms, 1805240865.3 ns, 4045552 ticks, 36104.8173 ns/op, 27697.1 op/s
Target 1: 50000 op, 1745.9 ms, 1745880864.1 ns, 3912526 ticks, 34917.6173 ns/op, 28638.8 op/s
Target 2: 50000 op, 1738 ms, 1738022332.8 ns, 3894915 ticks, 34760.4467 ns/op, 28768.3 op/s
Target 3: 50000 op, 2041.2 ms, 2041227057.2 ns, 4574398 ticks, 40824.5411 ns/op, 24495.1 op/s
Target 4: 50000 op, 1936.5 ms, 1936495874.2 ns, 4339695 ticks, 38729.9175 ns/op, 25819.8 op/s
Target 5: 50000 op, 1984.6 ms, 1984570754.9 ns, 4447431 ticks, 39691.4151 ns/op, 25194.4 op/s
Target 6: 50000 op, 1976.7 ms, 1976660014.9 ns, 4429703 ticks, 39533.2003 ns/op, 25295.2 op/s
Target 7: 50000 op, 2001.9 ms, 2001857649.5 ns, 4486171 ticks, 40037.153 ns/op, 24976.8 op/s
Target 8: 50000 op, 1951.8 ms, 1951756891.1 ns, 4373895 ticks, 39035.1378 ns/op, 25617.9 op/s
Target 9: 50000 op, 2038.3 ms, 2038342635.7 ns, 4567934 ticks, 40766.8527 ns/op, 24529.7 op/s
Target 10: 50000 op, 1991 ms, 1990990645.3 ns, 4461818 ticks, 39819.8129 ns/op, 25113.1 op/s
// Benchmark finished

AverageTime (ns/op): Avr=37266.1050665235 +- 809.20149793808
OperationsPerSecond: Avr=26930.0255410196 +- 585.959463243693

// **************************
// Benchmark: ComplexComparisonTest_DynamicCodeCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_DynamicCodeCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 35698.3 ns, 80 ticks, 35698.2852 ns/op, 28012.6 op/s
// Pre-Warmup: 1000 op, 0.8 ms, 819721.9 ns, 1837 ticks, 819.7219 ns/op, 1219926 op/s
// Pre-Warmup: 1000000 op, 841.7 ms, 841736560.9 ns, 1886335 ticks, 841.7366 ns/op, 1188020.2 op/s
// Pre-Warmup: 2000000 op, 1673.5 ms, 1673527579.6 ns, 3750382 ticks, 836.7638 ns/op, 1195080.4 op/s
// Warmup (idle): 2000000 op, 6.5 ms, 6477007.6 ns, 14515 ticks, 3.2385 ns/op, 308784567.7 op/s
// Warmup (idle): 2000000 op, 6.3 ms, 6282005.7 ns, 14078 ticks, 3.141 ns/op, 318369654.8 op/s
// Warmup (idle): 2000000 op, 6.7 ms, 6675579.3 ns, 14960 ticks, 3.3378 ns/op, 299599465.2 op/s
// IterationCount = 2000000
// Target (idle): 2000000 op, 6.7 ms, 6707261.6 ns, 15031 ticks, 3.3536 ns/op, 298184285.8 op/s
// Target (idle): 2000000 op, 6.3 ms, 6283344.4 ns, 14081 ticks, 3.1417 ns/op, 318301825.2 op/s
// Target (idle): 2000000 op, 6.6 ms, 6610430 ns, 14814 ticks, 3.3052 ns/op, 302552180.4 op/s
// Target (idle): 2000000 op, 6.4 ms, 6413643.2 ns, 14373 ticks, 3.2068 ns/op, 311835246.6 op/s
// Target (idle): 2000000 op, 6.6 ms, 6577855.3 ns, 14741 ticks, 3.2889 ns/op, 304050471.5 op/s
// Warmup 1: 2000000 op, 1667.9 ms, 1667876987.3 ns, 3737719 ticks, 833.9385 ns/op, 1199129.2 op/s
// Warmup 2: 2000000 op, 1560.8 ms, 1560795072.2 ns, 3497748 ticks, 780.3975 ns/op, 1281398.2 op/s
// Warmup 3: 2000000 op, 1553 ms, 1553007937.5 ns, 3480297 ticks, 776.504 ns/op, 1287823.4 op/s
// Warmup 4: 2000000 op, 1605.8 ms, 1605781158.8 ns, 3598562 ticks, 802.8906 ns/op, 1245499.7 op/s
// Warmup 5: 2000000 op, 1683.4 ms, 1683430730.2 ns, 3772575 ticks, 841.7154 ns/op, 1188050.1 op/s
Target 1: 2000000 op, 1554.8 ms, 1554816501.9 ns, 3484350 ticks, 777.4083 ns/op, 1286325.4 op/s
Target 2: 2000000 op, 1556.6 ms, 1556592937.8 ns, 3488331 ticks, 778.2965 ns/op, 1284857.4 op/s
Target 3: 2000000 op, 1568.9 ms, 1568926695.4 ns, 3515971 ticks, 784.4633 ns/op, 1274756.8 op/s
Target 4: 2000000 op, 1659 ms, 1659020242.7 ns, 3717871 ticks, 829.5101 ns/op, 1205530.8 op/s
Target 5: 2000000 op, 2124.8 ms, 2124761937.1 ns, 4761600 ticks, 1062.381 ns/op, 941281.9 op/s
Target 6: 2000000 op, 1953.2 ms, 1953217397.2 ns, 4377168 ticks, 976.6087 ns/op, 1023951.6 op/s
Target 7: 2000000 op, 1772.3 ms, 1772297595.2 ns, 3971726 ticks, 886.1488 ns/op, 1128478.7 op/s
Target 8: 2000000 op, 1683.5 ms, 1683543179.8 ns, 3772827 ticks, 841.7716 ns/op, 1187970.7 op/s
Target 9: 2000000 op, 1561.7 ms, 1561684405.7 ns, 3499741 ticks, 780.8422 ns/op, 1280668.5 op/s
Target 10: 2000000 op, 1573.2 ms, 1573206919.8 ns, 3525563 ticks, 786.6035 ns/op, 1271288.6 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 30343.5 ns, 68 ticks, 30343.5424 ns/op, 32955.9 op/s
// Pre-Warmup: 1000 op, 0.8 ms, 800980.3 ns, 1795 ticks, 800.9803 ns/op, 1248470.2 op/s
// Pre-Warmup: 1000000 op, 878.5 ms, 878483037.1 ns, 1968684 ticks, 878.483 ns/op, 1138325.9 op/s
// Pre-Warmup: 2000000 op, 2015.7 ms, 2015713492.7 ns, 4517222 ticks, 1007.8567 ns/op, 992204.5 op/s
// Warmup (idle): 2000000 op, 6.9 ms, 6893785.1 ns, 15449 ticks, 3.4469 ns/op, 290116382.9 op/s
// Warmup (idle): 2000000 op, 6.8 ms, 6752330.7 ns, 15132 ticks, 3.3762 ns/op, 296194025.9 op/s
// Warmup (idle): 2000000 op, 6.9 ms, 6854070.8 ns, 15360 ticks, 3.427 ns/op, 291797395.8 op/s
// IterationCount = 2000000
// Target (idle): 2000000 op, 6.8 ms, 6840683.9 ns, 15330 ticks, 3.4203 ns/op, 292368427.9 op/s
// Target (idle): 2000000 op, 6.7 ms, 6743406.1 ns, 15112 ticks, 3.3717 ns/op, 296586024.4 op/s
// Target (idle): 2000000 op, 6.9 ms, 6872366.1 ns, 15401 ticks, 3.4362 ns/op, 291020583.1 op/s
// Target (idle): 2000000 op, 6.7 ms, 6725556.9 ns, 15072 ticks, 3.3628 ns/op, 297373142.3 op/s
// Target (idle): 2000000 op, 7 ms, 6991062.9 ns, 15667 ticks, 3.4955 ns/op, 286079530.2 op/s
// Warmup 1: 2000000 op, 2027.6 ms, 2027551490.3 ns, 4543751 ticks, 1013.7757 ns/op, 986411.4 op/s
// Warmup 2: 2000000 op, 1563.3 ms, 1563255130.3 ns, 3503261 ticks, 781.6276 ns/op, 1279381.7 op/s
// Warmup 3: 2000000 op, 1559.2 ms, 1559235949.6 ns, 3494254 ticks, 779.618 ns/op, 1282679.5 op/s
// Warmup 4: 2000000 op, 1596.3 ms, 1596343870.9 ns, 3577413 ticks, 798.1719 ns/op, 1252862.9 op/s
// Warmup 5: 2000000 op, 1678.8 ms, 1678830113.6 ns, 3762265 ticks, 839.4151 ns/op, 1191305.8 op/s
Target 1: 2000000 op, 1671.1 ms, 1671058597 ns, 3744849 ticks, 835.5293 ns/op, 1196846.1 op/s
Target 2: 2000000 op, 1656.6 ms, 1656551706.3 ns, 3712339 ticks, 828.2759 ns/op, 1207327.2 op/s
Target 3: 2000000 op, 1666.3 ms, 1666347315.8 ns, 3734291 ticks, 833.1737 ns/op, 1200230 op/s
Target 4: 2000000 op, 1675.1 ms, 1675114814.6 ns, 3753939 ticks, 837.5574 ns/op, 1193948 op/s
Target 5: 2000000 op, 1653.9 ms, 1653897538.8 ns, 3706391 ticks, 826.9488 ns/op, 1209264.8 op/s
Target 6: 2000000 op, 1660.3 ms, 1660334832.1 ns, 3720817 ticks, 830.1674 ns/op, 1204576.3 op/s
Target 7: 2000000 op, 1666.5 ms, 1666452625.7 ns, 3734527 ticks, 833.2263 ns/op, 1200154.1 op/s
Target 8: 2000000 op, 1675.6 ms, 1675571306.4 ns, 3754962 ticks, 837.7857 ns/op, 1193622.7 op/s
Target 9: 2000000 op, 1662.2 ms, 1662158568.2 ns, 3724904 ticks, 831.0793 ns/op, 1203254.6 op/s
Target 10: 2000000 op, 1716.5 ms, 1716536873.7 ns, 3846766 ticks, 858.2684 ns/op, 1165136.6 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=DynamicCodeCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 23650.1 ns, 53 ticks, 23650.114 ns/op, 42283.1 op/s
// Pre-Warmup: 1000 op, 0.8 ms, 818829.4 ns, 1835 ticks, 818.8294 ns/op, 1221255.6 op/s
// Pre-Warmup: 1000000 op, 872.3 ms, 872288492.1 ns, 1954802 ticks, 872.2885 ns/op, 1146409.7 op/s
// Pre-Warmup: 2000000 op, 1626.6 ms, 1626595490.2 ns, 3645207 ticks, 813.2977 ns/op, 1229562 op/s
// Warmup (idle): 2000000 op, 6.3 ms, 6329752.2 ns, 14185 ticks, 3.1649 ns/op, 315968135.4 op/s
// Warmup (idle): 2000000 op, 6.3 ms, 6325736.1 ns, 14176 ticks, 3.1629 ns/op, 316168735.9 op/s
// Warmup (idle): 2000000 op, 6.4 ms, 6381960.9 ns, 14302 ticks, 3.191 ns/op, 313383303 op/s
// IterationCount = 2000000
// Target (idle): 2000000 op, 6.3 ms, 6254339.6 ns, 14016 ticks, 3.1272 ns/op, 319777968 op/s
// Target (idle): 2000000 op, 6.7 ms, 6650590.5 ns, 14904 ticks, 3.3253 ns/op, 300725174.4 op/s
// Target (idle): 2000000 op, 6.4 ms, 6409627.1 ns, 14364 ticks, 3.2048 ns/op, 312030632.1 op/s
// Target (idle): 2000000 op, 6.4 ms, 6427030 ns, 14403 ticks, 3.2135 ns/op, 311185725.2 op/s
// Target (idle): 2000000 op, 6.5 ms, 6541710.8 ns, 14660 ticks, 3.2709 ns/op, 305730422.9 op/s
// Warmup 1: 2000000 op, 1560.3 ms, 1560312252.9 ns, 3496666 ticks, 780.1561 ns/op, 1281794.7 op/s
// Warmup 2: 2000000 op, 1560.2 ms, 1560204711.8 ns, 3496425 ticks, 780.1024 ns/op, 1281883.1 op/s
// Warmup 3: 2000000 op, 1676.4 ms, 1676416463.3 ns, 3756856 ticks, 838.2082 ns/op, 1193021 op/s
// Warmup 4: 2000000 op, 1831.4 ms, 1831360408.1 ns, 4104086 ticks, 915.6802 ns/op, 1092084.3 op/s
// Warmup 5: 2000000 op, 1773 ms, 1772967384.3 ns, 3973227 ticks, 886.4837 ns/op, 1128052.3 op/s
Target 1: 2000000 op, 1672.2 ms, 1672151410.7 ns, 3747298 ticks, 836.0757 ns/op, 1196063.9 op/s
Target 2: 2000000 op, 1656 ms, 1656010431 ns, 3711126 ticks, 828.0052 ns/op, 1207721.9 op/s
Target 3: 2000000 op, 1675.1 ms, 1675132217.5 ns, 3753978 ticks, 837.5661 ns/op, 1193935.6 op/s
Target 4: 2000000 op, 1677.7 ms, 1677734622.5 ns, 3759810 ticks, 838.8673 ns/op, 1192083.6 op/s
Target 5: 2000000 op, 1688.8 ms, 1688799752.3 ns, 3784607 ticks, 844.3999 ns/op, 1184273 op/s
Target 6: 2000000 op, 1875.9 ms, 1875905620.9 ns, 4203912 ticks, 937.9528 ns/op, 1066151.7 op/s
Target 7: 2000000 op, 1666 ms, 1665999257.5 ns, 3733511 ticks, 832.9996 ns/op, 1200480.7 op/s
Target 8: 2000000 op, 1732.7 ms, 1732747911.2 ns, 3883095 ticks, 866.374 ns/op, 1154236 op/s
Target 9: 2000000 op, 1684.3 ms, 1684303553.2 ns, 3774531 ticks, 842.1518 ns/op, 1187434.4 op/s
Target 10: 2000000 op, 1668.4 ms, 1668438342.8 ns, 3738977 ticks, 834.2192 ns/op, 1198725.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=845.155251846667 +- 20.8261174973829
OperationsPerSecond: Avr=1188019.25352155 +- 25975.8885507075

// **************************
// Benchmark: ComplexComparisonTest_ManualCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_ManualCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 13386.9 ns, 30 ticks, 13386.857 ns/op, 74700.1 op/s
// Pre-Warmup: 1000 op, 1 ms, 950466.8 ns, 2130 ticks, 950.4668 ns/op, 1052114.6 op/s
// Pre-Warmup: 1000000 op, 1110.1 ms, 1110123409 ns, 2487791 ticks, 1110.1234 ns/op, 900800.8 op/s
// Warmup (idle): 1000000 op, 3.6 ms, 3591693.7 ns, 8049 ticks, 3.5917 ns/op, 278420176.4 op/s
// Warmup (idle): 1000000 op, 3.7 ms, 3655504.4 ns, 8192 ticks, 3.6555 ns/op, 273560058.6 op/s
// Warmup (idle): 1000000 op, 3.6 ms, 3577860.6 ns, 8018 ticks, 3.5779 ns/op, 279496632.6 op/s
// IterationCount = 1000000
// Target (idle): 1000000 op, 3.4 ms, 3384197.4 ns, 7584 ticks, 3.3842 ns/op, 295491033.8 op/s
// Target (idle): 1000000 op, 3.4 ms, 3373041.7 ns, 7559 ticks, 3.373 ns/op, 296468315.9 op/s
// Target (idle): 1000000 op, 3.6 ms, 3577414.4 ns, 8017 ticks, 3.5774 ns/op, 279531495.6 op/s
// Target (idle): 1000000 op, 3.8 ms, 3760814.3 ns, 8428 ticks, 3.7608 ns/op, 265899857.6 op/s
// Target (idle): 1000000 op, 3.2 ms, 3220877.8 ns, 7218 ticks, 3.2209 ns/op, 310474369.6 op/s
// Warmup 1: 1000000 op, 1038.2 ms, 1038202073.7 ns, 2326615 ticks, 1038.2021 ns/op, 963203.6 op/s
// Warmup 2: 1000000 op, 968.5 ms, 968538208.8 ns, 2170498 ticks, 968.5382 ns/op, 1032483.8 op/s
// Warmup 3: 1000000 op, 969.6 ms, 969568996.8 ns, 2172808 ticks, 969.569 ns/op, 1031386.1 op/s
// Warmup 4: 1000000 op, 897.1 ms, 897095230.5 ns, 2010394 ticks, 897.0952 ns/op, 1114708.9 op/s
// Warmup 5: 1000000 op, 905.1 ms, 905095216.3 ns, 2028322 ticks, 905.0952 ns/op, 1104856.1 op/s
Target 1: 1000000 op, 891.7 ms, 891689617.7 ns, 1998280 ticks, 891.6896 ns/op, 1121466.5 op/s
Target 2: 1000000 op, 894.3 ms, 894256770.6 ns, 2004033 ticks, 894.2568 ns/op, 1118247.1 op/s
Target 3: 1000000 op, 893.4 ms, 893351819.1 ns, 2002005 ticks, 893.3518 ns/op, 1119379.8 op/s
Target 4: 1000000 op, 988.4 ms, 988449373.6 ns, 2215119 ticks, 988.4494 ns/op, 1011685.6 op/s
Target 5: 1000000 op, 958.3 ms, 958268704.6 ns, 2147484 ticks, 958.2687 ns/op, 1043548.6 op/s
Target 6: 1000000 op, 962.8 ms, 962759102.6 ns, 2157547 ticks, 962.7591 ns/op, 1038681.4 op/s
Target 7: 1000000 op, 983.7 ms, 983698824.3 ns, 2204473 ticks, 983.6988 ns/op, 1016571.3 op/s
Target 8: 1000000 op, 957.8 ms, 957844341.2 ns, 2146533 ticks, 957.8443 ns/op, 1044011 op/s
Target 9: 1000000 op, 977.6 ms, 977590401.4 ns, 2190784 ticks, 977.5904 ns/op, 1022923.3 op/s
Target 10: 1000000 op, 959 ms, 959035325.2 ns, 2149202 ticks, 959.0353 ns/op, 1042714.5 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 26327.5 ns, 59 ticks, 26327.4854 ns/op, 37983.1 op/s
// Pre-Warmup: 1000 op, 1.5 ms, 1491742.1 ns, 3343 ticks, 1491.7421 ns/op, 670357.2 op/s
// Pre-Warmup: 671000 op, 667.3 ms, 667300906.2 ns, 1495424 ticks, 994.4872 ns/op, 1005543.4 op/s
// Pre-Warmup: 1342000 op, 1309.7 ms, 1309728585.9 ns, 2935107 ticks, 975.9527 ns/op, 1024639.8 op/s
// Warmup (idle): 1342000 op, 4.6 ms, 4648809.2 ns, 10418 ticks, 3.4641 ns/op, 288676076.8 op/s
// Warmup (idle): 1342000 op, 4.4 ms, 4356529.5 ns, 9763 ticks, 3.2463 ns/op, 308043364.5 op/s
// Warmup (idle): 1342000 op, 4.2 ms, 4202134.4 ns, 9417 ticks, 3.1312 ns/op, 319361513 op/s
// IterationCount = 1342000
// Target (idle): 1342000 op, 4.3 ms, 4318600.1 ns, 9678 ticks, 3.218 ns/op, 310748849.8 op/s
// Target (idle): 1342000 op, 4.4 ms, 4369023.9 ns, 9791 ticks, 3.2556 ns/op, 307162431.6 op/s
// Target (idle): 1342000 op, 4.4 ms, 4411861.8 ns, 9887 ticks, 3.2875 ns/op, 304179970.5 op/s
// Target (idle): 1342000 op, 4.2 ms, 4224445.8 ns, 9467 ticks, 3.1479 ns/op, 317674803.8 op/s
// Target (idle): 1342000 op, 4.7 ms, 4660857.4 ns, 10445 ticks, 3.4731 ns/op, 287929858.1 op/s
// Warmup 1: 1342000 op, 1339.1 ms, 1339050265 ns, 3000817 ticks, 997.802 ns/op, 1002202.9 op/s
// Warmup 2: 1342000 op, 1216.2 ms, 1216198632.4 ns, 2725506 ticks, 906.2583 ns/op, 1103438.2 op/s
// Warmup 3: 1342000 op, 1209.4 ms, 1209371781.6 ns, 2710207 ticks, 901.1712 ns/op, 1109667 op/s
// Warmup 4: 1342000 op, 1210.8 ms, 1210758660 ns, 2713315 ticks, 902.2047 ns/op, 1108396 op/s
// Warmup 5: 1342000 op, 1299.9 ms, 1299902186.7 ns, 2913086 ticks, 968.6305 ns/op, 1032385.4 op/s
Target 1: 1342000 op, 1305.8 ms, 1305778570.7 ns, 2926255 ticks, 973.0094 ns/op, 1027739.3 op/s
Target 2: 1342000 op, 1297.9 ms, 1297905313.9 ns, 2908611 ticks, 967.1426 ns/op, 1033973.7 op/s
Target 3: 1342000 op, 1337 ms, 1336955668.1 ns, 2996123 ticks, 996.2412 ns/op, 1003773 op/s
Target 4: 1342000 op, 1354 ms, 1354048899.5 ns, 3034429 ticks, 1008.9783 ns/op, 991101.6 op/s
Target 5: 1342000 op, 1304.1 ms, 1304082455.9 ns, 2922454 ticks, 971.7455 ns/op, 1029076 op/s
Target 6: 1342000 op, 1299 ms, 1299017761.7 ns, 2911104 ticks, 967.9715 ns/op, 1033088.3 op/s
Target 7: 1342000 op, 1306.4 ms, 1306446574.8 ns, 2927752 ticks, 973.5071 ns/op, 1027213.8 op/s
Target 8: 1342000 op, 1325 ms, 1324962382.9 ns, 2969246 ticks, 987.3043 ns/op, 1012858.9 op/s
Target 9: 1342000 op, 1309.9 ms, 1309859777.1 ns, 2935401 ticks, 976.0505 ns/op, 1024537.1 op/s
Target 10: 1342000 op, 1316.7 ms, 1316712063 ns, 2950757 ticks, 981.1565 ns/op, 1019205.4 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0 ms, 19634.1 ns, 44 ticks, 19634.0569 ns/op, 50931.9 op/s
// Pre-Warmup: 1000 op, 0.9 ms, 941096 ns, 2109 ticks, 941.096 ns/op, 1062590.8 op/s
// Pre-Warmup: 1000000 op, 972 ms, 971982200.8 ns, 2178216 ticks, 971.9822 ns/op, 1028825.4 op/s
// Pre-Warmup: 2000000 op, 1868.1 ms, 1868111792.8 ns, 4186446 ticks, 934.0559 ns/op, 1070599.7 op/s
// Warmup (idle): 2000000 op, 6.3 ms, 6330198.4 ns, 14186 ticks, 3.1651 ns/op, 315945862.1 op/s
// Warmup (idle): 2000000 op, 7 ms, 7009804.5 ns, 15709 ticks, 3.5049 ns/op, 285314660.4 op/s
// Warmup (idle): 2000000 op, 6.2 ms, 6248538.6 ns, 14003 ticks, 3.1243 ns/op, 320074841.1 op/s
// IterationCount = 2000000
// Target (idle): 2000000 op, 6.8 ms, 6803646.9 ns, 15247 ticks, 3.4018 ns/op, 293959992.1 op/s
// Target (idle): 2000000 op, 6.4 ms, 6447110.3 ns, 14448 ticks, 3.2236 ns/op, 310216500.6 op/s
// Target (idle): 2000000 op, 6.4 ms, 6449341.5 ns, 14453 ticks, 3.2247 ns/op, 310109181.5 op/s
// Target (idle): 2000000 op, 6.7 ms, 6687181.3 ns, 14986 ticks, 3.3436 ns/op, 299079674.4 op/s
// Target (idle): 2000000 op, 6.2 ms, 6248538.6 ns, 14003 ticks, 3.1243 ns/op, 320074841.1 op/s
// Warmup 1: 2000000 op, 1800.7 ms, 1800683532.9 ns, 4035339 ticks, 900.3418 ns/op, 1110689.3 op/s
// Warmup 2: 2000000 op, 1802.7 ms, 1802698254.9 ns, 4039854 ticks, 901.3491 ns/op, 1109448 op/s
// Warmup 3: 2000000 op, 1912.1 ms, 1912084048 ns, 4284988 ticks, 956.042 ns/op, 1045979.1 op/s
// Warmup 4: 2000000 op, 1941.7 ms, 1941696668.1 ns, 4351350 ticks, 970.8483 ns/op, 1030027 op/s
// Warmup 5: 2000000 op, 1913.4 ms, 1913415594.1 ns, 4287972 ticks, 956.7078 ns/op, 1045251.2 op/s
Target 1: 2000000 op, 1945.2 ms, 1945245077.7 ns, 4359302 ticks, 972.6225 ns/op, 1028148.1 op/s
Target 2: 2000000 op, 1930.4 ms, 1930388790 ns, 4326009 ticks, 965.1944 ns/op, 1036060.7 op/s
Target 3: 2000000 op, 1863.5 ms, 1863464768.5 ns, 4176032 ticks, 931.7324 ns/op, 1073269.6 op/s
Target 4: 2000000 op, 1789.8 ms, 1789802695.6 ns, 4010955 ticks, 894.9013 ns/op, 1117441.6 op/s
Target 5: 2000000 op, 1790.8 ms, 1790834822.2 ns, 4013268 ticks, 895.4174 ns/op, 1116797.6 op/s
Target 6: 2000000 op, 1864.4 ms, 1864383999.3 ns, 4178092 ticks, 932.192 ns/op, 1072740.4 op/s
Target 7: 2000000 op, 1959.1 ms, 1959073700.9 ns, 4390292 ticks, 979.5369 ns/op, 1020890.6 op/s
Target 8: 2000000 op, 1929.4 ms, 1929423151.4 ns, 4323845 ticks, 964.7116 ns/op, 1036579.2 op/s
Target 9: 2000000 op, 1937.6 ms, 1937572623.7 ns, 4342108 ticks, 968.7863 ns/op, 1032219.4 op/s
Target 10: 2000000 op, 1960.8 ms, 1960755982.6 ns, 4394062 ticks, 980.378 ns/op, 1020014.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=958.517466402074 +- 11.8669248362201
OperationsPerSecond: Avr=1044531.93993338 +- 13425.560802924

// **************************
// Benchmark: ComplexComparisonTest_ReflectionCompare (Throughput_X64_RyuJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_ReflectionCompare_Throughput_X64_RyuJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0.2 ms, 170013.1 ns, 381 ticks, 170013.0834 ns/op, 5881.9 op/s
// Pre-Warmup: 1000 op, 38.8 ms, 38771015.1 ns, 86886 ticks, 38771.0151 ns/op, 25792.5 op/s
// Pre-Warmup: 26000 op, 1004.6 ms, 1004601509 ns, 2251316 ticks, 38638.5196 ns/op, 25880.9 op/s
// Warmup (idle): 26000 op, 0.1 ms, 84337.2 ns, 189 ticks, 3.2437 ns/op, 308286264.6 op/s
// Warmup (idle): 26000 op, 0.1 ms, 87014.6 ns, 195 ticks, 3.3467 ns/op, 298800533.3 op/s
// Warmup (idle): 26000 op, 0.1 ms, 89245.7 ns, 200 ticks, 3.4325 ns/op, 291330520 op/s
// IterationCount = 26000
// Target (idle): 26000 op, 0.1 ms, 87014.6 ns, 195 ticks, 3.3467 ns/op, 298800533.3 op/s
// Target (idle): 26000 op, 0.1 ms, 87014.6 ns, 195 ticks, 3.3467 ns/op, 298800533.3 op/s
// Target (idle): 26000 op, 0.1 ms, 87014.6 ns, 195 ticks, 3.3467 ns/op, 298800533.3 op/s
// Target (idle): 26000 op, 0.1 ms, 87014.6 ns, 195 ticks, 3.3467 ns/op, 298800533.3 op/s
// Target (idle): 26000 op, 0.1 ms, 88353.3 ns, 198 ticks, 3.3982 ns/op, 294273252.5 op/s
// Warmup 1: 26000 op, 1005 ms, 1005025872.3 ns, 2252267 ticks, 38654.8412 ns/op, 25870 op/s
// Warmup 2: 26000 op, 1018.6 ms, 1018645214.4 ns, 2282788 ticks, 39178.6621 ns/op, 25524.1 op/s
// Warmup 3: 26000 op, 984.4 ms, 984439563.7 ns, 2206133 ticks, 37863.0601 ns/op, 26411 op/s
// Warmup 4: 26000 op, 922.5 ms, 922505716.2 ns, 2067339 ticks, 35480.9891 ns/op, 28184.1 op/s
// Warmup 5: 26000 op, 905.6 ms, 905611502.7 ns, 2029479 ticks, 34831.2116 ns/op, 28709.9 op/s
Target 1: 26000 op, 904.1 ms, 904072906.6 ns, 2026031 ticks, 34772.0349 ns/op, 28758.7 op/s
Target 2: 26000 op, 904.5 ms, 904548586.3 ns, 2027097 ticks, 34790.3302 ns/op, 28743.6 op/s
Target 3: 26000 op, 905.5 ms, 905522703.2 ns, 2029280 ticks, 34827.7963 ns/op, 28712.7 op/s
Target 4: 26000 op, 1024.3 ms, 1024266801.8 ns, 2295386 ticks, 39394.877 ns/op, 25384 op/s
Target 5: 26000 op, 1052.5 ms, 1052495667.1 ns, 2358647 ticks, 40480.6026 ns/op, 24703.2 op/s
Target 6: 26000 op, 1017.2 ms, 1017221745.3 ns, 2279598 ticks, 39123.9133 ns/op, 25559.8 op/s
Target 7: 26000 op, 997.4 ms, 997357880.7 ns, 2235083 ticks, 38359.9185 ns/op, 26068.9 op/s
Target 8: 26000 op, 1004.6 ms, 1004609541.1 ns, 2251334 ticks, 38638.8285 ns/op, 25880.7 op/s
Target 9: 26000 op, 1018.6 ms, 1018644321.9 ns, 2282786 ticks, 39178.6278 ns/op, 25524.1 op/s
Target 10: 26000 op, 1022.3 ms, 1022331508.6 ns, 2291049 ticks, 39320.4426 ns/op, 25432.1 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0.2 ms, 242748.3 ns, 544 ticks, 242748.3396 ns/op, 4119.5 op/s
// Pre-Warmup: 1000 op, 58 ms, 57991418.1 ns, 129959 ticks, 57991.4181 ns/op, 17243.9 op/s
// Pre-Warmup: 18000 op, 729.4 ms, 729388702.6 ns, 1634563 ticks, 40521.5946 ns/op, 24678.2 op/s
// Pre-Warmup: 36000 op, 1369.5 ms, 1369476805.9 ns, 3069003 ticks, 38041.0224 ns/op, 26287.4 op/s
// Warmup (idle): 36000 op, 0.1 ms, 115573.2 ns, 259 ticks, 3.2104 ns/op, 311490903.5 op/s
// Warmup (idle): 36000 op, 0.1 ms, 123159.1 ns, 276 ticks, 3.4211 ns/op, 292304869.6 op/s
// Warmup (idle): 36000 op, 0.1 ms, 121820.4 ns, 273 ticks, 3.3839 ns/op, 295517011 op/s
// IterationCount = 36000
// Target (idle): 36000 op, 0.1 ms, 122266.6 ns, 274 ticks, 3.3963 ns/op, 294438481.8 op/s
// Target (idle): 36000 op, 0.1 ms, 121820.4 ns, 273 ticks, 3.3839 ns/op, 295517011 op/s
// Target (idle): 36000 op, 0.1 ms, 123159.1 ns, 276 ticks, 3.4211 ns/op, 292304869.6 op/s
// Target (idle): 36000 op, 0.1 ms, 123159.1 ns, 276 ticks, 3.4211 ns/op, 292304869.6 op/s
// Target (idle): 36000 op, 0.1 ms, 121820.4 ns, 273 ticks, 3.3839 ns/op, 295517011 op/s
// Warmup 1: 36000 op, 1289.6 ms, 1289626881.5 ns, 2890059 ticks, 35822.9689 ns/op, 27915.1 op/s
// Warmup 2: 36000 op, 1212.4 ms, 1212434694.4 ns, 2717071 ticks, 33678.7415 ns/op, 29692.3 op/s
// Warmup 3: 36000 op, 1232.5 ms, 1232462324.9 ns, 2761953 ticks, 34235.0646 ns/op, 29209.8 op/s
// Warmup 4: 36000 op, 1316.3 ms, 1316300194 ns, 2949834 ticks, 36563.8943 ns/op, 27349.4 op/s
// Warmup 5: 36000 op, 1230.7 ms, 1230731850.5 ns, 2758075 ticks, 34186.9958 ns/op, 29250.9 op/s
Target 1: 36000 op, 1346.8 ms, 1346796346.6 ns, 3018176 ticks, 37411.0096 ns/op, 26730.1 op/s
Target 2: 36000 op, 1437.3 ms, 1437311133.8 ns, 3221020 ticks, 39925.3093 ns/op, 25046.8 op/s
Target 3: 36000 op, 1361 ms, 1361028806.7 ns, 3050071 ticks, 37806.3557 ns/op, 26450.6 op/s
Target 4: 36000 op, 1438.6 ms, 1438590917.3 ns, 3223888 ticks, 39960.8588 ns/op, 25024.5 op/s
Target 5: 36000 op, 1346.5 ms, 1346512099 ns, 3017539 ticks, 37403.1139 ns/op, 26735.7 op/s
Target 6: 36000 op, 1337.2 ms, 1337183690.9 ns, 2996634 ticks, 37143.9914 ns/op, 26922.3 op/s
Target 7: 36000 op, 1365.7 ms, 1365730270.9 ns, 3060607 ticks, 37936.952 ns/op, 26359.5 op/s
Target 8: 36000 op, 1378.5 ms, 1378546401.5 ns, 3089328 ticks, 38292.9556 ns/op, 26114.5 op/s
Target 9: 36000 op, 1352.6 ms, 1352623645.5 ns, 3031235 ticks, 37572.879 ns/op, 26614.9 op/s
Target 10: 36000 op, 1366 ms, 1365981497.6 ns, 3061170 ticks, 37943.9305 ns/op, 26354.7 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X64 JitVersion=RyuJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 0.1 ms, 111110.9 ns, 249 ticks, 111110.9128 ns/op, 9000 op/s
// Pre-Warmup: 1000 op, 38.8 ms, 38810729.5 ns, 86975 ticks, 38810.7295 ns/op, 25766.1 op/s
// Pre-Warmup: 26000 op, 981.9 ms, 981861701.3 ns, 2200356 ticks, 37763.9116 ns/op, 26480.3 op/s
// Pre-Warmup: 52000 op, 1825.9 ms, 1825933376.3 ns, 4091924 ticks, 35114.1034 ns/op, 28478.6 op/s
// Warmup (idle): 52000 op, 0.2 ms, 176260.3 ns, 395 ticks, 3.3896 ns/op, 295018248.1 op/s
// Warmup (idle): 52000 op, 0.2 ms, 221329.4 ns, 496 ticks, 4.2563 ns/op, 234943967.7 op/s
// Warmup (idle): 52000 op, 0.2 ms, 185184.9 ns, 415 ticks, 3.5612 ns/op, 280800501.2 op/s
// IterationCount = 52000
// Target (idle): 52000 op, 0.2 ms, 177599 ns, 398 ticks, 3.4154 ns/op, 292794492.5 op/s
// Target (idle): 52000 op, 0.2 ms, 175814.1 ns, 394 ticks, 3.381 ns/op, 295767025.4 op/s
// Target (idle): 52000 op, 0.2 ms, 238732.3 ns, 535 ticks, 4.591 ns/op, 217817211.2 op/s
// Target (idle): 52000 op, 0.2 ms, 175367.8 ns, 393 ticks, 3.3725 ns/op, 296519613.2 op/s
// Target (idle): 52000 op, 0.2 ms, 175367.8 ns, 393 ticks, 3.3725 ns/op, 296519613.2 op/s
// Warmup 1: 52000 op, 1774.5 ms, 1774476529.3 ns, 3976609 ticks, 34124.5486 ns/op, 29304.4 op/s
// Warmup 2: 52000 op, 1755.1 ms, 1755100392.5 ns, 3933187 ticks, 33751.9306 ns/op, 29627.9 op/s
// Warmup 3: 52000 op, 1961 ms, 1960971957.2 ns, 4394546 ticks, 37710.9992 ns/op, 26517.5 op/s
// Warmup 4: 52000 op, 1982 ms, 1982047778.6 ns, 4441777 ticks, 38116.3034 ns/op, 26235.5 op/s
// Warmup 5: 52000 op, 1981.6 ms, 1981560943.2 ns, 4440686 ticks, 38106.9412 ns/op, 26241.9 op/s
Target 1: 52000 op, 1861.1 ms, 1861149734.7 ns, 4170844 ticks, 35791.3411 ns/op, 27939.7 op/s
Target 2: 52000 op, 1773.3 ms, 1773261448.9 ns, 3973886 ticks, 34101.1817 ns/op, 29324.5 op/s
Target 3: 52000 op, 1760.5 ms, 1760453796.6 ns, 3945184 ticks, 33854.8807 ns/op, 29537.8 op/s
Target 4: 52000 op, 1882.1 ms, 1882062236.4 ns, 4217709 ticks, 36193.5045 ns/op, 27629.3 op/s
Target 5: 52000 op, 1960.2 ms, 1960205782.8 ns, 4392829 ticks, 37696.2651 ns/op, 26527.8 op/s
Target 6: 52000 op, 1938.2 ms, 1938167000.1 ns, 4343440 ticks, 37272.4423 ns/op, 26829.5 op/s
Target 7: 52000 op, 1959.8 ms, 1959826488.5 ns, 4391979 ticks, 37688.9709 ns/op, 26533 op/s
Target 8: 52000 op, 1981.4 ms, 1981373527.2 ns, 4440266 ticks, 38103.3371 ns/op, 26244.4 op/s
Target 9: 52000 op, 1892.8 ms, 1892803850.4 ns, 4241781 ticks, 36400.074 ns/op, 27472.5 op/s
Target 10: 52000 op, 1990.8 ms, 1990834465.3 ns, 4461468 ticks, 38285.2782 ns/op, 26119.7 op/s
// Benchmark finished

AverageTime (ns/op): Avr=37522.4001020157 +- 630.99495736652
OperationsPerSecond: Avr=26709.3183747344 +- 462.002601770698

// **************************
// Benchmark: ComplexComparisonTest_DynamicCodeCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_DynamicCodeCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=DynamicCodeCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 19634.1 ns, 44 ticks, 19634.0569 ns/op, 50931.9 op/s
// Pre-Warmup: 1000 op, 0.7 ms, 738062 ns, 1654 ticks, 738.062 ns/op, 1354899.6 op/s
// Pre-Warmup: 1000000 op, 784.3 ms, 784349336.3 ns, 1757730 ticks, 784.3493 ns/op, 1274942.1 op/s
// Pre-Warmup: 2000000 op, 1499.3 ms, 1499329764.7 ns, 3360004 ticks, 749.6649 ns/op, 1333929.4 op/s
// Warmup (idle): 2000000 op, 6.6 ms, 6613553.6 ns, 14821 ticks, 3.3068 ns/op, 302409284.1 op/s
// Warmup (idle): 2000000 op, 5.6 ms, 5551975.8 ns, 12442 ticks, 2.776 ns/op, 360232117 op/s
// Warmup (idle): 2000000 op, 5.9 ms, 5906727.5 ns, 13237 ticks, 2.9534 ns/op, 338596963.1 op/s
// IterationCount = 2000000
// Target (idle): 2000000 op, 5.8 ms, 5821944.1 ns, 13047 ticks, 2.911 ns/op, 343527860.8 op/s
// Target (idle): 2000000 op, 5.6 ms, 5616679 ns, 12587 ticks, 2.8083 ns/op, 356082307.1 op/s
// Target (idle): 2000000 op, 6 ms, 6012483.7 ns, 13474 ticks, 3.0062 ns/op, 332641235 op/s
// Target (idle): 2000000 op, 5.7 ms, 5650146.1 ns, 12662 ticks, 2.8251 ns/op, 353973148 op/s
// Target (idle): 2000000 op, 5.6 ms, 5587227.9 ns, 12521 ticks, 2.7936 ns/op, 357959268.4 op/s
// Warmup 1: 2000000 op, 1515.2 ms, 1515203453.5 ns, 3395577 ticks, 757.6017 ns/op, 1319954.8 op/s
// Warmup 2: 2000000 op, 1466.3 ms, 1466320452.8 ns, 3286030 ticks, 733.1602 ns/op, 1363958.3 op/s
// Warmup 3: 2000000 op, 1522.2 ms, 1522163726.6 ns, 3411175 ticks, 761.0819 ns/op, 1313919.1 op/s
// Warmup 4: 2000000 op, 1554.7 ms, 1554700036.2 ns, 3484089 ticks, 777.35 ns/op, 1286421.8 op/s
// Warmup 5: 2000000 op, 1562.1 ms, 1562062361.3 ns, 3500588 ticks, 781.0312 ns/op, 1280358.6 op/s
Target 1: 2000000 op, 1557.7 ms, 1557664778.8 ns, 3490733 ticks, 778.8324 ns/op, 1283973.3 op/s
Target 2: 2000000 op, 1557.8 ms, 1557809356.9 ns, 3491057 ticks, 778.9047 ns/op, 1283854.1 op/s
Target 3: 2000000 op, 1474.5 ms, 1474487328 ns, 3304332 ticks, 737.2437 ns/op, 1356403.7 op/s
Target 4: 2000000 op, 1471.4 ms, 1471397195.2 ns, 3297407 ticks, 735.6986 ns/op, 1359252.3 op/s
Target 5: 2000000 op, 1491.8 ms, 1491750572.5 ns, 3343019 ticks, 745.8753 ns/op, 1340706.7 op/s
Target 6: 2000000 op, 1508.6 ms, 1508597932 ns, 3380774 ticks, 754.299 ns/op, 1325734.3 op/s
Target 7: 2000000 op, 1553 ms, 1552983841.2 ns, 3480243 ticks, 776.4919 ns/op, 1287843.4 op/s
Target 8: 2000000 op, 1561.7 ms, 1561708948.3 ns, 3499796 ticks, 780.8545 ns/op, 1280648.4 op/s
Target 9: 2000000 op, 1578.6 ms, 1578625919.5 ns, 3537707 ticks, 789.313 ns/op, 1266924.6 op/s
Target 10: 2000000 op, 1551.8 ms, 1551777239.1 ns, 3477539 ticks, 775.8886 ns/op, 1288844.8 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=DynamicCodeCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 25435 ns, 57 ticks, 25435.0282 ns/op, 39315.9 op/s
// Pre-Warmup: 1000 op, 1.3 ms, 1293616.6 ns, 2899 ticks, 1293.6166 ns/op, 773026.6 op/s
// Pre-Warmup: 774000 op, 581.2 ms, 581199319.6 ns, 1302470 ticks, 750.9035 ns/op, 1331729 op/s
// Pre-Warmup: 1548000 op, 1139.1 ms, 1139084535.3 ns, 2552693 ticks, 735.8427 ns/op, 1358986.1 op/s
// Warmup (idle): 1548000 op, 4.6 ms, 4590799.5 ns, 10288 ticks, 2.9656 ns/op, 337196169.5 op/s
// Warmup (idle): 1548000 op, 4.5 ms, 4546622.9 ns, 10189 ticks, 2.9371 ns/op, 340472489.2 op/s
// Warmup (idle): 1548000 op, 4.3 ms, 4300304.7 ns, 9637 ticks, 2.778 ns/op, 359974493.3 op/s
// IterationCount = 1548000
// Target (idle): 1548000 op, 4.4 ms, 4401152.3 ns, 9863 ticks, 2.8431 ns/op, 351726066.3 op/s
// Target (idle): 1548000 op, 4.6 ms, 4595708 ns, 10299 ticks, 2.9688 ns/op, 336836022.1 op/s
// Target (idle): 1548000 op, 4.3 ms, 4298073.5 ns, 9632 ticks, 2.7765 ns/op, 360161357.1 op/s
// Target (idle): 1548000 op, 4.4 ms, 4373486.2 ns, 9801 ticks, 2.8252 ns/op, 353951045 op/s
// Target (idle): 1548000 op, 4.5 ms, 4494860.3 ns, 10073 ticks, 2.9037 ns/op, 344393347.8 op/s
// Warmup 1: 1548000 op, 1138.4 ms, 1138351381.8 ns, 2551050 ticks, 735.3691 ns/op, 1359861.3 op/s
// Warmup 2: 1548000 op, 1133 ms, 1133019396.7 ns, 2539101 ticks, 731.9247 ns/op, 1366260.8 op/s
// Warmup 3: 1548000 op, 1132 ms, 1131960496.3 ns, 2536728 ticks, 731.2406 ns/op, 1367538.9 op/s
// Warmup 4: 1548000 op, 1222.3 ms, 1222251276.7 ns, 2739070 ticks, 789.568 ns/op, 1266515.3 op/s
// Warmup 5: 1548000 op, 1198.8 ms, 1198823384.5 ns, 2686568 ticks, 774.4337 ns/op, 1291266.1 op/s
Target 1: 1548000 op, 1202.1 ms, 1202098702.2 ns, 2693908 ticks, 776.5495 ns/op, 1287747.8 op/s
Target 2: 1548000 op, 1201.5 ms, 1201502540.8 ns, 2692572 ticks, 776.1644 ns/op, 1288386.8 op/s
Target 3: 1548000 op, 1193.2 ms, 1193238387.8 ns, 2674052 ticks, 770.8258 ns/op, 1297309.9 op/s
Target 4: 1548000 op, 1206.8 ms, 1206846127.9 ns, 2704547 ticks, 779.6164 ns/op, 1282682.2 op/s
Target 5: 1548000 op, 1204.5 ms, 1204509228.9 ns, 2699310 ticks, 778.1067 ns/op, 1285170.7 op/s
Target 6: 1548000 op, 1200.7 ms, 1200658276.4 ns, 2690680 ticks, 775.619 ns/op, 1289292.7 op/s
Target 7: 1548000 op, 1196.6 ms, 1196606967.2 ns, 2681601 ticks, 773.0019 ns/op, 1293657.9 op/s
Target 8: 1548000 op, 1301.4 ms, 1301401068.4 ns, 2916445 ticks, 840.6984 ns/op, 1189487.3 op/s
Target 9: 1548000 op, 1220.2 ms, 1220231199.9 ns, 2734543 ticks, 788.263 ns/op, 1268612 op/s
Target 10: 1548000 op, 1209.1 ms, 1209120108.7 ns, 2709643 ticks, 781.0853 ns/op, 1280269.8 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=DynamicCodeCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 30789.8 ns, 69 ticks, 30789.771 ns/op, 32478.3 op/s
// Pre-Warmup: 1000 op, 1.1 ms, 1094598.7 ns, 2453 ticks, 1094.5987 ns/op, 913576.8 op/s
// Pre-Warmup: 914000 op, 705.1 ms, 705073708 ns, 1580073 ticks, 771.4154 ns/op, 1296318.4 op/s
// Pre-Warmup: 1828000 op, 1346.9 ms, 1346896748.1 ns, 3018401 ticks, 736.8144 ns/op, 1357193.9 op/s
// Warmup (idle): 1828000 op, 5.1 ms, 5115118 ns, 11463 ticks, 2.7982 ns/op, 357372006.6 op/s
// Warmup (idle): 1828000 op, 5.2 ms, 5150370.1 ns, 11542 ticks, 2.8175 ns/op, 354925949.7 op/s
// Warmup (idle): 1828000 op, 5.2 ms, 5176697.6 ns, 11601 ticks, 2.8319 ns/op, 353120878.5 op/s
// IterationCount = 1828000
// Target (idle): 1828000 op, 5.1 ms, 5144569.1 ns, 11529 ticks, 2.8143 ns/op, 355326161.2 op/s
// Target (idle): 1828000 op, 5.1 ms, 5149923.9 ns, 11541 ticks, 2.8172 ns/op, 354956703.2 op/s
// Target (idle): 1828000 op, 5.3 ms, 5257018.7 ns, 11781 ticks, 2.8758 ns/op, 347725601.6 op/s
// Target (idle): 1828000 op, 5.1 ms, 5147246.5 ns, 11535 ticks, 2.8158 ns/op, 355141336.1 op/s
// Target (idle): 1828000 op, 5.2 ms, 5248986.6 ns, 11763 ticks, 2.8714 ns/op, 348257698.9 op/s
// Warmup 1: 1828000 op, 1355 ms, 1354985087 ns, 3036527 ticks, 741.2391 ns/op, 1349092.3 op/s
// Warmup 2: 1828000 op, 1334.8 ms, 1334795475.6 ns, 2991282 ticks, 730.1945 ns/op, 1369498.2 op/s
// Warmup 3: 1828000 op, 1431 ms, 1431049654.5 ns, 3206988 ticks, 782.8499 ns/op, 1277384 op/s
// Warmup 4: 1828000 op, 1419.4 ms, 1419419599.4 ns, 3180925 ticks, 776.4877 ns/op, 1287850.3 op/s
// Warmup 5: 1828000 op, 1419.7 ms, 1419691798.9 ns, 3181535 ticks, 776.6367 ns/op, 1287603.4 op/s
Target 1: 1828000 op, 1413.9 ms, 1413857360.4 ns, 3168460 ticks, 773.4449 ns/op, 1292916.8 op/s
Target 2: 1828000 op, 1388.3 ms, 1388292033.4 ns, 3111168 ticks, 759.4595 ns/op, 1316725.8 op/s
Target 3: 1828000 op, 1415.9 ms, 1415914474 ns, 3173070 ticks, 774.5703 ns/op, 1291038.4 op/s
Target 4: 1828000 op, 1476.2 ms, 1476238328.9 ns, 3308256 ticks, 807.5702 ns/op, 1238282.4 op/s
Target 5: 1828000 op, 1443 ms, 1442993854.5 ns, 3233755 ticks, 789.3839 ns/op, 1266810.7 op/s
Target 6: 1828000 op, 1331.6 ms, 1331551840.2 ns, 2984013 ticks, 728.42 ns/op, 1372834.3 op/s
Target 7: 1828000 op, 1339.1 ms, 1339130139.9 ns, 3000996 ticks, 732.5657 ns/op, 1365065.2 op/s
Target 8: 1828000 op, 1392.4 ms, 1392373239.9 ns, 3120314 ticks, 761.6921 ns/op, 1312866.4 op/s
Target 9: 1828000 op, 1376.1 ms, 1376115794.5 ns, 3083881 ticks, 752.7986 ns/op, 1328376.6 op/s
Target 10: 1828000 op, 1435.3 ms, 1435268745.6 ns, 3216443 ticks, 785.158 ns/op, 1273629.1 op/s
// Benchmark finished

AverageTime (ns/op): Avr=771.946517843501 +- 8.1602390654633
OperationsPerSecond: Avr=1296511.61519548 +- 13615.7225901008

// **************************
// Benchmark: ComplexComparisonTest_ManualCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_ManualCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 17849.1 ns, 40 ticks, 17849.1426 ns/op, 56025.1 op/s
// Pre-Warmup: 1000 op, 1.1 ms, 1084335.4 ns, 2430 ticks, 1084.3354 ns/op, 922223.9 op/s
// Pre-Warmup: 923000 op, 845.1 ms, 845061410 ns, 1893786 ticks, 915.5595 ns/op, 1092228.3 op/s
// Pre-Warmup: 1846000 op, 1621.3 ms, 1621305896.8 ns, 3633353 ticks, 878.2806 ns/op, 1138588.3 op/s
// Warmup (idle): 1846000 op, 5.3 ms, 5271744.3 ns, 11814 ticks, 2.8558 ns/op, 350168730.7 op/s
// Warmup (idle): 1846000 op, 5.2 ms, 5176251.4 ns, 11600 ticks, 2.804 ns/op, 356628740 op/s
// Warmup (idle): 1846000 op, 5.3 ms, 5319937 ns, 11922 ticks, 2.8819 ns/op, 346996593.2 op/s
// IterationCount = 1846000
// Target (idle): 1846000 op, 5.6 ms, 5634528.1 ns, 12627 ticks, 3.0523 ns/op, 327622822.8 op/s
// Target (idle): 1846000 op, 5.3 ms, 5330646.4 ns, 11946 ticks, 2.8877 ns/op, 346299462.9 op/s
// Target (idle): 1846000 op, 5.2 ms, 5179375 ns, 11607 ticks, 2.8057 ns/op, 356413662.8 op/s
// Target (idle): 1846000 op, 5.4 ms, 5428816.7 ns, 12166 ticks, 2.9409 ns/op, 340037266.5 op/s
// Target (idle): 1846000 op, 5.2 ms, 5176697.6 ns, 11601 ticks, 2.8043 ns/op, 356597998.8 op/s
// Warmup 1: 1846000 op, 1573.9 ms, 1573948551.6 ns, 3527225 ticks, 852.6265 ns/op, 1172846.5 op/s
// Warmup 2: 1846000 op, 1626.2 ms, 1626230475.3 ns, 3644389 ticks, 880.9483 ns/op, 1135140.5 op/s
// Warmup 3: 1846000 op, 1611.8 ms, 1611845851.2 ns, 3612153 ticks, 873.1559 ns/op, 1145270.8 op/s
// Warmup 4: 1846000 op, 1694.3 ms, 1694252665.3 ns, 3796827 ticks, 917.7967 ns/op, 1089565.9 op/s
// Warmup 5: 1846000 op, 1685.4 ms, 1685422248.2 ns, 3777038 ticks, 913.0131 ns/op, 1095274.5 op/s
Target 1: 1846000 op, 1691.2 ms, 1691208940.3 ns, 3790006 ticks, 916.1479 ns/op, 1091526.9 op/s
Target 2: 1846000 op, 1579.4 ms, 1579353272 ns, 3539337 ticks, 855.5543 ns/op, 1168832.9 op/s
Target 3: 1846000 op, 1623.2 ms, 1623196567.3 ns, 3637590 ticks, 879.3047 ns/op, 1137262.1 op/s
Target 4: 1846000 op, 1562.8 ms, 1562813364 ns, 3502271 ticks, 846.5945 ns/op, 1181203.1 op/s
Target 5: 1846000 op, 1724.1 ms, 1724062964.6 ns, 3863632 ticks, 933.9453 ns/op, 1070726.6 op/s
Target 6: 1846000 op, 1672.5 ms, 1672474926.4 ns, 3748023 ticks, 905.9994 ns/op, 1103753.5 op/s
Target 7: 1846000 op, 1690.5 ms, 1690513269.9 ns, 3788447 ticks, 915.771 ns/op, 1091976 op/s
Target 8: 1846000 op, 1708.8 ms, 1708816227 ns, 3829464 ticks, 925.6859 ns/op, 1080280 op/s
Target 9: 1846000 op, 1710.8 ms, 1710771600.6 ns, 3833846 ticks, 926.7452 ns/op, 1079045.3 op/s
Target 10: 1846000 op, 1683.5 ms, 1683455272.7 ns, 3772630 ticks, 911.9476 ns/op, 1096554.2 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 16956.7 ns, 38 ticks, 16956.6855 ns/op, 58973.8 op/s
// Pre-Warmup: 1000 op, 1.4 ms, 1417221.9 ns, 3176 ticks, 1417.2219 ns/op, 705605.8 op/s
// Pre-Warmup: 706000 op, 683 ms, 683004581.9 ns, 1530616 ticks, 967.4286 ns/op, 1033668 op/s
// Pre-Warmup: 1412000 op, 1287.1 ms, 1287080701.3 ns, 2884353 ticks, 911.5302 ns/op, 1097056.3 op/s
// Warmup (idle): 1412000 op, 3.9 ms, 3934843.5 ns, 8818 ticks, 2.7867 ns/op, 358845276.5 op/s
// Warmup (idle): 1412000 op, 4.1 ms, 4113334.9 ns, 9218 ticks, 2.9131 ns/op, 343273773.9 op/s
// Warmup (idle): 1412000 op, 4.1 ms, 4125383.1 ns, 9245 ticks, 2.9217 ns/op, 342271243.7 op/s
// IterationCount = 1412000
// Target (idle): 1412000 op, 3.9 ms, 3947337.9 ns, 8846 ticks, 2.7956 ns/op, 357709433.4 op/s
// Target (idle): 1412000 op, 3.9 ms, 3932612.3 ns, 8813 ticks, 2.7851 ns/op, 359048865.1 op/s
// Target (idle): 1412000 op, 4.5 ms, 4522080.3 ns, 10134 ticks, 3.2026 ns/op, 312245672.8 op/s
// Target (idle): 1412000 op, 4.6 ms, 4646131.8 ns, 10412 ticks, 3.2905 ns/op, 303908725.3 op/s
// Target (idle): 1412000 op, 4.2 ms, 4248542.2 ns, 9521 ticks, 3.0089 ns/op, 332349296.1 op/s
// Warmup 1: 1412000 op, 1334.3 ms, 1334283651.4 ns, 2990135 ticks, 944.9601 ns/op, 1058245.7 op/s
// Warmup 2: 1412000 op, 1350.8 ms, 1350789646.1 ns, 3027125 ticks, 956.6499 ns/op, 1045314.5 op/s
// Warmup 3: 1412000 op, 1298.5 ms, 1298459976 ns, 2909854 ticks, 919.5892 ns/op, 1087442.1 op/s
// Warmup 4: 1412000 op, 1356.2 ms, 1356235865.7 ns, 3039330 ticks, 960.507 ns/op, 1041116.8 op/s
// Warmup 5: 1412000 op, 1316.5 ms, 1316510813.9 ns, 2950306 ticks, 932.3731 ns/op, 1072532 op/s
Target 1: 1412000 op, 1297.6 ms, 1297624636.1 ns, 2907982 ticks, 918.9976 ns/op, 1088142.1 op/s
Target 2: 1412000 op, 1356.8 ms, 1356782941.9 ns, 3040556 ticks, 960.8944 ns/op, 1040697 op/s
Target 3: 1412000 op, 1287.2 ms, 1287157898.9 ns, 2884526 ticks, 911.5849 ns/op, 1096990.5 op/s
Target 4: 1412000 op, 1362.3 ms, 1362345181 ns, 3053021 ticks, 964.8337 ns/op, 1036448 op/s
Target 5: 1412000 op, 1303.6 ms, 1303631318.8 ns, 2921443 ticks, 923.2516 ns/op, 1083128.3 op/s
Target 6: 1412000 op, 1219.8 ms, 1219776939.3 ns, 2733525 ticks, 863.8647 ns/op, 1157588.7 op/s
Target 7: 1412000 op, 1344.8 ms, 1344770022.7 ns, 3013635 ticks, 952.3867 ns/op, 1049993.7 op/s
Target 8: 1412000 op, 1292.5 ms, 1292504609.5 ns, 2896508 ticks, 915.3715 ns/op, 1092452.6 op/s
Target 9: 1412000 op, 1290.9 ms, 1290863827.1 ns, 2892831 ticks, 914.2095 ns/op, 1093841.2 op/s
Target 10: 1412000 op, 1299.7 ms, 1299706738.6 ns, 2912648 ticks, 920.4722 ns/op, 1086398.9 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ManualCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0 ms, 9817 ns, 22 ticks, 9817.0284 ns/op, 101863.8 op/s
// Pre-Warmup: 1000 op, 1.1 ms, 1057115.5 ns, 2369 ticks, 1057.1155 ns/op, 945970.5 op/s
// Pre-Warmup: 946000 op, 920.6 ms, 920603443.8 ns, 2063076 ticks, 973.1537 ns/op, 1027586.9 op/s
// Pre-Warmup: 1892000 op, 1724.1 ms, 1724125882.9 ns, 3863773 ticks, 911.2716 ns/op, 1097367.7 op/s
// Warmup (idle): 1892000 op, 5.6 ms, 5568932.5 ns, 12480 ticks, 2.9434 ns/op, 339741952.6 op/s
// Warmup (idle): 1892000 op, 5.3 ms, 5298071.8 ns, 11873 ticks, 2.8002 ns/op, 357111056 op/s
// Warmup (idle): 1892000 op, 5.4 ms, 5381962.7 ns, 12061 ticks, 2.8446 ns/op, 351544612.2 op/s
// IterationCount = 1892000
// Target (idle): 1892000 op, 5.3 ms, 5343587.1 ns, 11975 ticks, 2.8243 ns/op, 354069275 op/s
// Target (idle): 1892000 op, 5.3 ms, 5306550.1 ns, 11892 ticks, 2.8047 ns/op, 356540495.1 op/s
// Target (idle): 1892000 op, 5.4 ms, 5379285.4 ns, 12055 ticks, 2.8432 ns/op, 351719582.6 op/s
// Target (idle): 1892000 op, 5.6 ms, 5648807.4 ns, 12659 ticks, 2.9856 ns/op, 334937954.7 op/s
// Target (idle): 1892000 op, 5.9 ms, 5884416.1 ns, 13187 ticks, 3.1102 ns/op, 321527228.9 op/s
// Warmup 1: 1892000 op, 1743.5 ms, 1743539056.6 ns, 3907278 ticks, 921.5323 ns/op, 1085149.2 op/s
// Warmup 2: 1892000 op, 1735.6 ms, 1735581908.8 ns, 3889446 ticks, 917.3266 ns/op, 1090124.3 op/s
// Warmup 3: 1892000 op, 1732.6 ms, 1732606903 ns, 3882779 ticks, 915.7542 ns/op, 1091996.1 op/s
// Warmup 4: 1892000 op, 1730.5 ms, 1730541310.9 ns, 3878150 ticks, 914.6624 ns/op, 1093299.5 op/s
// Warmup 5: 1892000 op, 1755.6 ms, 1755645237.6 ns, 3934408 ticks, 927.9309 ns/op, 1077666.5 op/s
Target 1: 1892000 op, 1722.2 ms, 1722222718 ns, 3859508 ticks, 910.2657 ns/op, 1098580.3 op/s
Target 2: 1892000 op, 1731.6 ms, 1731597980.2 ns, 3880518 ticks, 915.2209 ns/op, 1092632.4 op/s
Target 3: 1892000 op, 1730.6 ms, 1730629218 ns, 3878347 ticks, 914.7089 ns/op, 1093244 op/s
Target 4: 1892000 op, 1739.7 ms, 1739651513.3 ns, 3898566 ticks, 919.4775 ns/op, 1087574.1 op/s
Target 5: 1892000 op, 1727.8 ms, 1727785849.6 ns, 3871975 ticks, 913.2061 ns/op, 1095043.1 op/s
Target 6: 1892000 op, 1736.3 ms, 1736251251.7 ns, 3890946 ticks, 917.6804 ns/op, 1089704 op/s
Target 7: 1892000 op, 1691.7 ms, 1691713178.6 ns, 3791136 ticks, 894.1402 ns/op, 1118392.9 op/s
Target 8: 1892000 op, 1732.8 ms, 1732772900 ns, 3883151 ticks, 915.8419 ns/op, 1091891.5 op/s
Target 9: 1892000 op, 1722.4 ms, 1722350339.4 ns, 3859794 ticks, 910.3332 ns/op, 1098498.9 op/s
Target 10: 1892000 op, 1764.8 ms, 1764814342.1 ns, 3954956 ticks, 932.7771 ns/op, 1072067.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=913.573818617416 +- 9.32316031420909
OperationsPerSecond: Avr=1095482.34529031 +- 11435.5383506935

// **************************
// Benchmark: ComplexComparisonTest_ReflectionCompare (Throughput_X86_LegacyJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\ComplexComparisonTest_ReflectionCompare_Throughput_X86_LegacyJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0.1 ms, 82106.1 ns, 184 ticks, 82106.056 ns/op, 12179.4 op/s
// Pre-Warmup: 1000 op, 35.5 ms, 35474724.7 ns, 79499 ticks, 35474.7247 ns/op, 28189.1 op/s
// Pre-Warmup: 29000 op, 950 ms, 949958143.8 ns, 2128860 ticks, 32757.1774 ns/op, 30527.7 op/s
// Pre-Warmup: 58000 op, 1814.9 ms, 1814853967.2 ns, 4067095 ticks, 31290.5856 ns/op, 31958.5 op/s
// Warmup (idle): 58000 op, 0.2 ms, 200802.9 ns, 450 ticks, 3.4621 ns/op, 288840515.6 op/s
// Warmup (idle): 58000 op, 0.2 ms, 196786.8 ns, 441 ticks, 3.3929 ns/op, 294735220 op/s
// Warmup (idle): 58000 op, 0.2 ms, 200802.9 ns, 450 ticks, 3.4621 ns/op, 288840515.6 op/s
// IterationCount = 58000
// Target (idle): 58000 op, 0.2 ms, 194555.7 ns, 436 ticks, 3.3544 ns/op, 298115211 op/s
// Target (idle): 58000 op, 0.2 ms, 195448.1 ns, 438 ticks, 3.3698 ns/op, 296753954.3 op/s
// Target (idle): 58000 op, 0.2 ms, 195448.1 ns, 438 ticks, 3.3698 ns/op, 296753954.3 op/s
// Target (idle): 58000 op, 0.2 ms, 196340.6 ns, 440 ticks, 3.3852 ns/op, 295405072.7 op/s
// Target (idle): 58000 op, 0.2 ms, 196340.6 ns, 440 ticks, 3.3852 ns/op, 295405072.7 op/s
// Warmup 1: 58000 op, 1739 ms, 1739006266.8 ns, 3897120 ticks, 29982.8667 ns/op, 33352.4 op/s
// Warmup 2: 58000 op, 1706.7 ms, 1706681469.6 ns, 3824680 ticks, 29425.5426 ns/op, 33984.1 op/s
// Warmup 3: 58000 op, 1824.6 ms, 1824575502.8 ns, 4088881 ticks, 31458.1983 ns/op, 31788.2 op/s
// Warmup 4: 58000 op, 1903 ms, 1902989463.7 ns, 4264607 ticks, 32810.1632 ns/op, 30478.4 op/s
// Warmup 5: 58000 op, 2023 ms, 2023023609.1 ns, 4533604 ticks, 34879.7174 ns/op, 28670 op/s
Target 1: 58000 op, 1825.7 ms, 1825652698.5 ns, 4091295 ticks, 31476.7707 ns/op, 31769.5 op/s
Target 2: 58000 op, 1722.4 ms, 1722415935 ns, 3859941 ticks, 29696.8265 ns/op, 33673.6 op/s
Target 3: 58000 op, 1704.9 ms, 1704867550.4 ns, 3820615 ticks, 29394.2681 ns/op, 34020.2 op/s
Target 4: 58000 op, 1813.2 ms, 1813234157.5 ns, 4063465 ticks, 31262.6579 ns/op, 31987 op/s
Target 5: 58000 op, 1883.3 ms, 1883341573.7 ns, 4220576 ticks, 32471.4064 ns/op, 30796.3 op/s
Target 6: 58000 op, 1909.4 ms, 1909381687.9 ns, 4278932 ticks, 32920.3739 ns/op, 30376.3 op/s
Target 7: 58000 op, 1876.1 ms, 1876104192.6 ns, 4204357 ticks, 32346.624 ns/op, 30915.1 op/s
Target 8: 58000 op, 1936.8 ms, 1936845717.4 ns, 4340479 ticks, 33393.8917 ns/op, 29945.6 op/s
Target 9: 58000 op, 2006.2 ms, 2006245415 ns, 4496004 ticks, 34590.4382 ns/op, 28909.7 op/s
Target 10: 58000 op, 1879.3 ms, 1879346043.1 ns, 4211622 ticks, 32402.518 ns/op, 30861.8 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0.2 ms, 164658.3 ns, 369 ticks, 164658.3406 ns/op, 6073.2 op/s
// Pre-Warmup: 1000 op, 46.6 ms, 46569751.8 ns, 104363 ticks, 46569.7518 ns/op, 21473.2 op/s
// Pre-Warmup: 22000 op, 701.2 ms, 701213830.9 ns, 1571423 ticks, 31873.356 ns/op, 31374.2 op/s
// Pre-Warmup: 44000 op, 1520.1 ms, 1520083409 ns, 3406513 ticks, 34547.3502 ns/op, 28945.8 op/s
// Warmup (idle): 44000 op, 0.2 ms, 150379 ns, 337 ticks, 3.4177 ns/op, 292593994.1 op/s
// Warmup (idle): 44000 op, 0.1 ms, 149040.3 ns, 334 ticks, 3.3873 ns/op, 295222083.8 op/s
// Warmup (idle): 44000 op, 0.1 ms, 149932.8 ns, 336 ticks, 3.4076 ns/op, 293464809.5 op/s
// IterationCount = 44000
// Target (idle): 44000 op, 0.1 ms, 147255.4 ns, 330 ticks, 3.3467 ns/op, 298800533.3 op/s
// Target (idle): 44000 op, 0.1 ms, 148594.1 ns, 333 ticks, 3.3771 ns/op, 296108636.6 op/s
// Target (idle): 44000 op, 0.1 ms, 148594.1 ns, 333 ticks, 3.3771 ns/op, 296108636.6 op/s
// Target (idle): 44000 op, 0.1 ms, 149040.3 ns, 334 ticks, 3.3873 ns/op, 295222083.8 op/s
// Target (idle): 44000 op, 0.1 ms, 149486.6 ns, 335 ticks, 3.3974 ns/op, 294340823.9 op/s
// Warmup 1: 44000 op, 1308.7 ms, 1308687088.5 ns, 2932773 ticks, 29742.8884 ns/op, 33621.5 op/s
// Warmup 2: 44000 op, 1297.3 ms, 1297335480 ns, 2907334 ticks, 29484.8973 ns/op, 33915.7 op/s
// Warmup 3: 44000 op, 1280.6 ms, 1280559517.1 ns, 2869739 ticks, 29103.6254 ns/op, 34360 op/s
// Warmup 4: 44000 op, 1298.2 ms, 1298239539.1 ns, 2909360 ticks, 29505.4441 ns/op, 33892.1 op/s
// Warmup 5: 44000 op, 1390.6 ms, 1390563336.8 ns, 3116258 ticks, 31603.7122 ns/op, 31641.9 op/s
Target 1: 44000 op, 1425.3 ms, 1425348192.1 ns, 3194211 ticks, 32394.2771 ns/op, 30869.7 op/s
Target 2: 44000 op, 1424.3 ms, 1424291969.1 ns, 3191844 ticks, 32370.272 ns/op, 30892.5 op/s
Target 3: 44000 op, 1431.2 ms, 1431173706.1 ns, 3207266 ticks, 32526.6751 ns/op, 30744 op/s
Target 4: 44000 op, 1480.1 ms, 1480103114.5 ns, 3316917 ticks, 33638.7071 ns/op, 29727.7 op/s
Target 5: 44000 op, 1298.3 ms, 1298276576 ns, 2909443 ticks, 29506.2858 ns/op, 33891.1 op/s
Target 6: 44000 op, 1300.3 ms, 1300337705.8 ns, 2914062 ticks, 29553.1297 ns/op, 33837.4 op/s
Target 7: 44000 op, 1291.9 ms, 1291852223.4 ns, 2895046 ticks, 29360.2778 ns/op, 34059.6 op/s
Target 8: 44000 op, 1287.6 ms, 1287561735.7 ns, 2885431 ticks, 29262.7667 ns/op, 34173.1 op/s
Target 9: 44000 op, 1435.8 ms, 1435758704.6 ns, 3217541 ticks, 32630.8796 ns/op, 30645.8 op/s
Target 10: 44000 op, 1464.4 ms, 1464384713.3 ns, 3281692 ticks, 33281.4708 ns/op, 30046.7 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=ReflectionCompare Platform=X86 JitVersion=LegacyJit 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=32-bit 
// Pre-Warmup: 1 op, 0.1 ms, 88799.5 ns, 199 ticks, 88799.4845 ns/op, 11261.3 op/s
// Pre-Warmup: 1000 op, 32.4 ms, 32395301.4 ns, 72598 ticks, 32395.3014 ns/op, 30868.7 op/s
// Pre-Warmup: 31000 op, 1084 ms, 1083969952.8 ns, 2429181 ticks, 34966.7727 ns/op, 28598.6 op/s
// Warmup (idle): 31000 op, 0.1 ms, 108433.5 ns, 243 ticks, 3.4979 ns/op, 285889399.2 op/s
// Warmup (idle): 31000 op, 0.1 ms, 105309.9 ns, 236 ticks, 3.3971 ns/op, 294369169.5 op/s
// Warmup (idle): 31000 op, 0.1 ms, 103971.3 ns, 233 ticks, 3.3539 ns/op, 298159330.5 op/s
// IterationCount = 31000
// Target (idle): 31000 op, 0.1 ms, 103971.3 ns, 233 ticks, 3.3539 ns/op, 298159330.5 op/s
// Target (idle): 31000 op, 0.1 ms, 103971.3 ns, 233 ticks, 3.3539 ns/op, 298159330.5 op/s
// Target (idle): 31000 op, 0.1 ms, 103971.3 ns, 233 ticks, 3.3539 ns/op, 298159330.5 op/s
// Target (idle): 31000 op, 0.1 ms, 104863.7 ns, 235 ticks, 3.3827 ns/op, 295621804.3 op/s
// Target (idle): 31000 op, 0.1 ms, 104863.7 ns, 235 ticks, 3.3827 ns/op, 295621804.3 op/s
// Warmup 1: 31000 op, 1084.9 ms, 1084898554.4 ns, 2431262 ticks, 34996.7276 ns/op, 28574.1 op/s
// Warmup 2: 31000 op, 1074.3 ms, 1074274744.7 ns, 2407454 ticks, 34654.024 ns/op, 28856.7 op/s
// Warmup 3: 31000 op, 1071.3 ms, 1071326958.8 ns, 2400848 ticks, 34558.9342 ns/op, 28936.1 op/s
// Warmup 4: 31000 op, 1092.4 ms, 1092418398.2 ns, 2448114 ticks, 35239.3032 ns/op, 28377.4 op/s
// Warmup 5: 31000 op, 1078.9 ms, 1078909274.6 ns, 2417840 ticks, 34803.525 ns/op, 28732.7 op/s
Target 1: 31000 op, 1086.6 ms, 1086570572.8 ns, 2435009 ticks, 35050.6636 ns/op, 28530.1 op/s
Target 2: 31000 op, 976.4 ms, 976368627.6 ns, 2188046 ticks, 31495.7622 ns/op, 31750.3 op/s
Target 3: 31000 op, 970.1 ms, 970084837 ns, 2173964 ticks, 31293.0593 ns/op, 31956 op/s
Target 4: 31000 op, 967.4 ms, 967390955.1 ns, 2167927 ticks, 31206.1598 ns/op, 32045 op/s
Target 5: 31000 op, 972.6 ms, 972643957.8 ns, 2179699 ticks, 31375.6115 ns/op, 31871.9 op/s
Target 6: 31000 op, 966.2 ms, 966224067.4 ns, 2165312 ticks, 31168.5183 ns/op, 32083.7 op/s
Target 7: 31000 op, 1035.2 ms, 1035177090.3 ns, 2319836 ticks, 33392.8094 ns/op, 29946.6 op/s
Target 8: 31000 op, 1090 ms, 1090032414 ns, 2442767 ticks, 35162.3359 ns/op, 28439.5 op/s
Target 9: 31000 op, 1061.1 ms, 1061074411.3 ns, 2377872 ticks, 34228.2068 ns/op, 29215.7 op/s
Target 10: 31000 op, 1064.3 ms, 1064255128.5 ns, 2385000 ticks, 34330.8106 ns/op, 29128.4 op/s
// Benchmark finished

AverageTime (ns/op): Avr=32106.148489101 +- 625.657483790872
OperationsPerSecond: Avr=31236.9962690455 +- 614.912170056844

// ***** Competition: Finish  *****

```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=ComplexComparisonTest  Mode=Throughput  .NET=HostFramework  
```

             Method | Platform |       Jit |        AvrTime |        StdDev |         op/s |
------------------- |--------- |---------- |--------------- |-------------- |------------- |
 DynamicCodeCompare |      X64 | LegacyJit |  1,104.7155 ns |    32.9474 ns |   905,210.51 |
      ManualCompare |      X64 | LegacyJit |  1,360.3273 ns |    39.9703 ns |   735,117.32 |
  ReflectionCompare |      X64 | LegacyJit | 38,043.3600 ns | 2,261.3159 ns |    26,290.11 |
 DynamicCodeCompare |      X64 |    RyuJit |    834.8742 ns |    58.1986 ns | 1,197,785.93 |
      ManualCompare |      X64 |    RyuJit |    968.3789 ns |    33.1622 ns | 1,032,653.82 |
  ReflectionCompare |      X64 |    RyuJit | 37,751.3104 ns | 1,763.3172 ns |    26,489.20 |
 DynamicCodeCompare |      X86 | LegacyJit |    776.0265 ns |    22.8038 ns | 1,288,615.79 |
      ManualCompare |      X86 | LegacyJit |    915.5713 ns |    26.0536 ns | 1,092,214.32 |
  ReflectionCompare |      X86 | LegacyJit | 32,382.2746 ns | 1,748.4016 ns |    30,881.10 |

// ***** Competition: End *****
```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit  [AttachedDebugger] [RyuJIT]
Type=ComplexComparisonTest  Mode=Throughput  .NET=HostFramework  
```

             Method | Platform |       Jit |        AvrTime |        StdDev |         op/s |
------------------- |--------- |---------- |--------------- |-------