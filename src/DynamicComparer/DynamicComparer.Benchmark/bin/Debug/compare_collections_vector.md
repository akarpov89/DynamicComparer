// ***** Competition: Start   *****
// Found benchmarks:
//   CollectionBenchmark_CompareCollectionsNonGeneric_Throughput_HostPlatform_HostJit_NET-HostFramework -w=5 -t=10
//   CollectionBenchmark_CompareCollectionsUseLinq_Throughput_HostPlatform_HostJit_NET-HostFramework -w=5 -t=10

// **************************
// Benchmark: CollectionBenchmark_CompareCollectionsNonGeneric (Throughput_HostPlatform_HostJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\CollectionBenchmark_CompareCollectionsNonGeneric_Throughput_HostPlatform_HostJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=CompareCollectionsNonGeneric 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 3.1 ms, 3064696.4 ns, 6868 ticks, 3064696.4197 ns/op, 326.3 op/s
// Pre-Warmup: 327 op, 955.6 ms, 955642223 ns, 2141599 ticks, 2922453.2814 ns/op, 342.2 op/s
// Pre-Warmup: 654 op, 1926.4 ms, 1926391507.4 ns, 4317053 ticks, 2945552.7636 ns/op, 339.5 op/s
// Warmup (idle): 654 op, 0 ms, 13386.9 ns, 30 ticks, 20.4692 ns/op, 48853909 op/s
// Warmup (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// Warmup (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// IterationCount = 654
// Target (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// Target (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// Target (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// Target (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// Target (idle): 654 op, 0 ms, 2231.1 ns, 5 ticks, 3.4115 ns/op, 293123454 op/s
// Warmup 1: 654 op, 1953.1 ms, 1953095597.7 ns, 4376897 ticks, 2986384.706 ns/op, 334.9 op/s
// Warmup 2: 654 op, 1932.7 ms, 1932709654.8 ns, 4331212 ticks, 2955213.5395 ns/op, 338.4 op/s
// Warmup 3: 654 op, 1906.2 ms, 1906217076.7 ns, 4271842 ticks, 2914705.0103 ns/op, 343.1 op/s
// Warmup 4: 654 op, 1929.5 ms, 1929491455.8 ns, 4324000 ticks, 2950292.7459 ns/op, 338.9 op/s
// Warmup 5: 654 op, 1923.7 ms, 1923658358.6 ns, 4310928 ticks, 2941373.6371 ns/op, 340 op/s
Target 1: 654 op, 1939 ms, 1938964437.8 ns, 4345229 ticks, 2964777.4279 ns/op, 337.3 op/s
Target 2: 654 op, 1947 ms, 1947042956.2 ns, 4363333 ticks, 2977129.9024 ns/op, 335.9 op/s
Target 3: 654 op, 1913.9 ms, 1913873463 ns, 4289000 ticks, 2926412.023 ns/op, 341.7 op/s
Target 4: 654 op, 1934.3 ms, 1934290641.9 ns, 4334755 ticks, 2957630.951 ns/op, 338.1 op/s
Target 5: 654 op, 1907 ms, 1906992175.4 ns, 4273579 ticks, 2915890.1764 ns/op, 342.9 op/s
Target 6: 654 op, 1913.7 ms, 1913673998.9 ns, 4288553 ticks, 2926107.032 ns/op, 341.8 op/s
Target 7: 654 op, 1896.7 ms, 1896662434.9 ns, 4250430 ticks, 2900095.4663 ns/op, 344.8 op/s
Target 8: 654 op, 1927.4 ms, 1927432111.9 ns, 4319385 ticks, 2947143.902 ns/op, 339.3 op/s
Target 9: 654 op, 1909.8 ms, 1909800290.5 ns, 4279872 ticks, 2920183.9304 ns/op, 342.4 op/s
Target 10: 654 op, 1926.4 ms, 1926358486.5 ns, 4316979 ticks, 2945502.2729 ns/op, 339.5 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=CompareCollectionsNonGeneric 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 4 ms, 3969647.5 ns, 8896 ticks, 3969647.5465 ns/op, 251.9 op/s
// Pre-Warmup: 252 op, 761.6 ms, 761609635 ns, 1706771 ticks, 3022260.4562 ns/op, 330.9 op/s
// Pre-Warmup: 504 op, 1513.1 ms, 1513135847.5 ns, 3390945 ticks, 3002253.6657 ns/op, 333.1 op/s
// Warmup (idle): 504 op, 0 ms, 5354.7 ns, 12 ticks, 10.6245 ns/op, 94122210 op/s
// Warmup (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// Warmup (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// IterationCount = 504
// Target (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// Target (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// Target (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// Target (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// Target (idle): 504 op, 0 ms, 1784.9 ns, 4 ticks, 3.5415 ns/op, 282366630 op/s
// Warmup 1: 504 op, 1557.8 ms, 1557812231.6 ns, 3491065 ticks, 3090897.2849 ns/op, 323.5 op/s
// Warmup 2: 504 op, 1504.7 ms, 1504740060.8 ns, 3372130 ticks, 2985595.3588 ns/op, 334.9 op/s
// Warmup 3: 504 op, 1552.2 ms, 1552225898.6 ns, 3478546 ticks, 3079813.291 ns/op, 324.7 op/s
// Warmup 4: 504 op, 1506.6 ms, 1506633854 ns, 3376374 ticks, 2989352.8849 ns/op, 334.5 op/s
// Warmup 5: 504 op, 1557.1 ms, 1557063014.1 ns, 3489386 ticks, 3089410.7423 ns/op, 323.7 op/s
Target 1: 504 op, 1493.9 ms, 1493882878.4 ns, 3347799 ticks, 2964053.3302 ns/op, 337.4 op/s
Target 2: 504 op, 1565.9 ms, 1565929125.5 ns, 3509255 ticks, 3107002.2332 ns/op, 321.9 op/s
Target 3: 504 op, 1509.1 ms, 1509071153.3 ns, 3381836 ticks, 2994188.7963 ns/op, 334 op/s
Target 4: 504 op, 1515.7 ms, 1515684257.7 ns, 3396656 ticks, 3007310.0352 ns/op, 332.5 op/s
Target 5: 504 op, 1496.9 ms, 1496901613.3 ns, 3354564 ticks, 2970042.8836 ns/op, 336.7 op/s
Target 6: 504 op, 1523.7 ms, 1523663713.4 ns, 3414538 ticks, 3023142.2884 ns/op, 330.8 op/s
Target 7: 504 op, 1519 ms, 1519008659.1 ns, 3404106 ticks, 3013906.0696 ns/op, 331.8 op/s
Target 8: 504 op, 1533.1 ms, 1533071099.8 ns, 3435620 ticks, 3041807.7377 ns/op, 328.8 op/s
Target 9: 504 op, 1491.6 ms, 1491642365.8 ns, 3342778 ticks, 2959607.8687 ns/op, 337.9 op/s
Target 10: 504 op, 1524.2 ms, 1524195617.6 ns, 3415730 ticks, 3024197.654 ns/op, 330.7 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=CompareCollectionsNonGeneric 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 5.7 ms, 5734927 ns, 12852 ticks, 5734926.9636 ns/op, 174.4 op/s
// Pre-Warmup: 175 op, 519.5 ms, 519528068.9 ns, 1164265 ticks, 2968731.8222 ns/op, 336.8 op/s
// Pre-Warmup: 350 op, 1019.5 ms, 1019468051.2 ns, 2284633 ticks, 2912765.8605 ns/op, 343.3 op/s
// Warmup (idle): 350 op, 0 ms, 5801 ns, 13 ticks, 16.5742 ns/op, 60334750 op/s
// Warmup (idle): 350 op, 0 ms, 1338.7 ns, 3 ticks, 3.8248 ns/op, 261450583.3 op/s
// Warmup (idle): 350 op, 0 ms, 1338.7 ns, 3 ticks, 3.8248 ns/op, 261450583.3 op/s
// IterationCount = 350
// Target (idle): 350 op, 0 ms, 1784.9 ns, 4 ticks, 5.0998 ns/op, 196087937.5 op/s
// Target (idle): 350 op, 0 ms, 1338.7 ns, 3 ticks, 3.8248 ns/op, 261450583.3 op/s
// Target (idle): 350 op, 0 ms, 1338.7 ns, 3 ticks, 3.8248 ns/op, 261450583.3 op/s
// Target (idle): 350 op, 0 ms, 1338.7 ns, 3 ticks, 3.8248 ns/op, 261450583.3 op/s
// Target (idle): 350 op, 0 ms, 1338.7 ns, 3 ticks, 3.8248 ns/op, 261450583.3 op/s
// Warmup 1: 350 op, 1029.2 ms, 1029170840.8 ns, 2306377 ticks, 2940488.1165 ns/op, 340.1 op/s
// Warmup 2: 350 op, 1018.9 ms, 1018931238.4 ns, 2283430 ticks, 2911232.1098 ns/op, 343.5 op/s
// Warmup 3: 350 op, 1023.1 ms, 1023051264.9 ns, 2292663 ticks, 2923003.6141 ns/op, 342.1 op/s
// Warmup 4: 350 op, 1012.7 ms, 1012717508.4 ns, 2269505 ticks, 2893478.5955 ns/op, 345.6 op/s
// Warmup 5: 350 op, 1037.2 ms, 1037203843.8 ns, 2324379 ticks, 2963439.5537 ns/op, 337.4 op/s
Target 1: 350 op, 1024.9 ms, 1024898650.4 ns, 2296803 ticks, 2928281.8582 ns/op, 341.5 op/s
Target 2: 350 op, 1022.2 ms, 1022188259.3 ns, 2290729 ticks, 2920537.8837 ns/op, 342.4 op/s
Target 3: 350 op, 1024.7 ms, 1024728191.1 ns, 2296421 ticks, 2927794.8318 ns/op, 341.6 op/s
Target 4: 350 op, 1006.5 ms, 1006506902 ns, 2255587 ticks, 2875734.0058 ns/op, 347.7 op/s
Target 5: 350 op, 1013.8 ms, 1013797381.1 ns, 2271925 ticks, 2896563.946 ns/op, 345.2 op/s
Target 6: 350 op, 1026.8 ms, 1026753175.5 ns, 2300959 ticks, 2933580.5014 ns/op, 340.9 op/s
Target 7: 350 op, 1021.8 ms, 1021823244.5 ns, 2289911 ticks, 2919494.9842 ns/op, 342.5 op/s
Target 8: 350 op, 1052.9 ms, 1052933393.7 ns, 2359629 ticks, 3008381.1249 ns/op, 332.4 op/s
Target 9: 350 op, 1019 ms, 1019006651 ns, 2283599 ticks, 2911447.5744 ns/op, 343.5 op/s
Target 10: 350 op, 1032.9 ms, 1032917374.1 ns, 2314773 ticks, 2951192.4975 ns/op, 338.8 op/s
// Benchmark finished

AverageTime (ns/op): Avr=2958638.03961464 +- 18163.9764620807
OperationsPerSecond: Avr=338.08816782699 +- 2.04630190946259

// **************************
// Benchmark: CollectionBenchmark_CompareCollectionsUseLinq (Throughput_HostPlatform_HostJit_NET-HostFramework) [-w=5 -t=10]
// Generated project: C:\Users\Andrew\Documents\GitHub\DynamicComparer\src\DynamicComparer\DynamicComparer.Benchmark\bin\Debug\CollectionBenchmark_CompareCollectionsUseLinq_Throughput_HostPlatform_HostJit_NET-HostFramework

// Build:
// OverallResult = Success

// Run, Process: 1 / 3
// Method=CompareCollectionsUseLinq 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 3 ms, 2991068.7 ns, 6703 ticks, 2991068.7392 ns/op, 334.3 op/s
// Pre-Warmup: 335 op, 1023.3 ms, 1023271701.8 ns, 2293157 ticks, 3054542.3933 ns/op, 327.4 op/s
// Warmup (idle): 335 op, 0 ms, 6247.2 ns, 14 ticks, 18.6483 ns/op, 53624048.2 op/s
// Warmup (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// Warmup (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// IterationCount = 335
// Target (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// Target (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// Target (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// Target (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// Target (idle): 335 op, 0 ms, 1338.7 ns, 3 ticks, 3.9961 ns/op, 250245558.3 op/s
// Warmup 1: 335 op, 1025.1 ms, 1025053045.4 ns, 2297149 ticks, 3059859.837 ns/op, 326.8 op/s
// Warmup 2: 335 op, 1024.6 ms, 1024578258.4 ns, 2296085 ticks, 3058442.5624 ns/op, 327 op/s
// Warmup 3: 335 op, 1062 ms, 1062011017.4 ns, 2379972 ticks, 3170182.1414 ns/op, 315.4 op/s
// Warmup 4: 335 op, 1026.5 ms, 1026521583 ns, 2300440 ticks, 3064243.5312 ns/op, 326.3 op/s
// Warmup 5: 335 op, 1008.4 ms, 1008412743.4 ns, 2259858 ticks, 3010187.2937 ns/op, 332.2 op/s
Target 1: 335 op, 1011.6 ms, 1011602383.8 ns, 2267006 ticks, 3019708.6082 ns/op, 331.2 op/s
Target 2: 335 op, 1008.6 ms, 1008602390.4 ns, 2260283 ticks, 3010753.4043 ns/op, 332.1 op/s
Target 3: 335 op, 1024.7 ms, 1024675090 ns, 2296302 ticks, 3058731.6119 ns/op, 326.9 op/s
Target 4: 335 op, 1041.9 ms, 1041887010.5 ns, 2334874 ticks, 3110110.4792 ns/op, 321.5 op/s
Target 5: 335 op, 1035.4 ms, 1035380554.7 ns, 2320293 ticks, 3090688.223 ns/op, 323.6 op/s
Target 6: 335 op, 1009.7 ms, 1009658613 ns, 2262650 ticks, 3013906.3074 ns/op, 331.8 op/s
Target 7: 335 op, 1036.8 ms, 1036756723 ns, 2323377 ticks, 3094796.188 ns/op, 323.1 op/s
Target 8: 335 op, 1010.1 ms, 1010093685.6 ns, 2263625 ticks, 3015205.0318 ns/op, 331.7 op/s
Target 9: 335 op, 1004.9 ms, 1004857642 ns, 2251891 ticks, 2999575.0507 ns/op, 333.4 op/s
Target 10: 335 op, 1016.1 ms, 1016090102.4 ns, 2277063 ticks, 3033104.7834 ns/op, 329.7 op/s
// Benchmark finished
// Run, Process: 2 / 3
// Method=CompareCollectionsUseLinq 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 4.7 ms, 4734929.2 ns, 10611 ticks, 4734929.1947 ns/op, 211.2 op/s
// Pre-Warmup: 212 op, 635.3 ms, 635261858 ns, 1423625 ticks, 2996518.1979 ns/op, 333.7 op/s
// Pre-Warmup: 424 op, 1258.2 ms, 1258191302.6 ns, 2819613 ticks, 2967432.3174 ns/op, 337 op/s
// Warmup (idle): 424 op, 0 ms, 6247.2 ns, 14 ticks, 14.734 ns/op, 67870437.1 op/s
// Warmup (idle): 424 op, 0 ms, 1784.9 ns, 4 ticks, 4.2097 ns/op, 237546530 op/s
// Warmup (idle): 424 op, 0 ms, 1338.7 ns, 3 ticks, 3.1573 ns/op, 316728706.7 op/s
// IterationCount = 424
// Target (idle): 424 op, 0 ms, 1784.9 ns, 4 ticks, 4.2097 ns/op, 237546530 op/s
// Target (idle): 424 op, 0 ms, 1338.7 ns, 3 ticks, 3.1573 ns/op, 316728706.7 op/s
// Target (idle): 424 op, 0 ms, 1338.7 ns, 3 ticks, 3.1573 ns/op, 316728706.7 op/s
// Target (idle): 424 op, 0 ms, 1338.7 ns, 3 ticks, 3.1573 ns/op, 316728706.7 op/s
// Target (idle): 424 op, 0 ms, 1338.7 ns, 3 ticks, 3.1573 ns/op, 316728706.7 op/s
// Warmup 1: 424 op, 1263.3 ms, 1263309541.9 ns, 2831083 ticks, 2979503.6366 ns/op, 335.6 op/s
// Warmup 2: 424 op, 1260.1 ms, 1260149798.9 ns, 2824002 ticks, 2972051.4124 ns/op, 336.5 op/s
// Warmup 3: 424 op, 1264.5 ms, 1264530869 ns, 2833820 ticks, 2982384.1249 ns/op, 335.3 op/s
// Warmup 4: 424 op, 1322.6 ms, 1322550373.6 ns, 2963842 ticks, 3119222.5793 ns/op, 320.6 op/s
// Warmup 5: 424 op, 1267.7 ms, 1267703998.9 ns, 2840931 ticks, 2989867.9219 ns/op, 334.5 op/s
Target 1: 424 op, 1258.3 ms, 1258294381.3 ns, 2819844 ticks, 2967675.4276 ns/op, 337 op/s
Target 2: 424 op, 1268 ms, 1268029745.6 ns, 2841661 ticks, 2990636.1924 ns/op, 334.4 op/s
Target 3: 424 op, 1257.5 ms, 1257534008.2 ns, 2818140 ticks, 2965882.0948 ns/op, 337.2 op/s
Target 4: 424 op, 1291.5 ms, 1291513405.8 ns, 2894288 ticks, 3046022.1835 ns/op, 328.3 op/s
Target 5: 424 op, 1274.9 ms, 1274882474.6 ns, 2857018 ticks, 3006798.2892 ns/op, 332.6 op/s
Target 6: 424 op, 1277 ms, 1276968146 ns, 2861692 ticks, 3011717.3254 ns/op, 332 op/s
Target 7: 424 op, 1431.2 ms, 1431202072.3 ns, 3207331 ticks, 3375476.5856 ns/op, 296.3 op/s
Target 8: 424 op, 1300.9 ms, 1300872599.6 ns, 2915262 ticks, 3068095.7537 ns/op, 325.9 op/s
Target 9: 424 op, 1298 ms, 1298026555.1 ns, 2908884 ticks, 3061383.3846 ns/op, 326.6 op/s
Target 10: 424 op, 1271.3 ms, 1271289890 ns, 2848967 ticks, 2998325.2123 ns/op, 333.5 op/s
// Benchmark finished
// Run, Process: 3 / 3
// Method=CompareCollectionsUseLinq 
// BenchmarkDotNet=v0.7.8.0
// OS=Microsoft Windows NT 6.2.9200.0
// Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
// CLR=MS.NET 4.0.30319.42000, Arch=64-bit  [RyuJIT]
// Pre-Warmup: 1 op, 3.2 ms, 3240510.4 ns, 7262 ticks, 3240510.396 ns/op, 308.6 op/s
// Pre-Warmup: 309 op, 936.5 ms, 936506165.8 ns, 2098715 ticks, 3030764.2905 ns/op, 329.9 op/s
// Pre-Warmup: 618 op, 1844.3 ms, 1844307353.2 ns, 4133102 ticks, 2984316.1055 ns/op, 335.1 op/s
// Warmup (idle): 618 op, 0 ms, 7585.9 ns, 17 ticks, 12.2749 ns/op, 81467122.9 op/s
// Warmup (idle): 618 op, 0 ms, 2677.4 ns, 6 ticks, 4.3323 ns/op, 230823515 op/s
// Warmup (idle): 618 op, 0 ms, 2231.1 ns, 5 ticks, 3.6103 ns/op, 276988218 op/s
// IterationCount = 618
// Target (idle): 618 op, 0 ms, 2231.1 ns, 5 ticks, 3.6103 ns/op, 276988218 op/s
// Target (idle): 618 op, 0 ms, 2677.4 ns, 6 ticks, 4.3323 ns/op, 230823515 op/s
// Target (idle): 618 op, 0 ms, 2231.1 ns, 5 ticks, 3.6103 ns/op, 276988218 op/s
// Target (idle): 618 op, 0 ms, 2677.4 ns, 6 ticks, 4.3323 ns/op, 230823515 op/s
// Target (idle): 618 op, 0 ms, 2231.1 ns, 5 ticks, 3.6103 ns/op, 276988218 op/s
// Warmup 1: 618 op, 1861.9 ms, 1861899014.1 ns, 4172525 ticks, 3012781.5761 ns/op, 331.9 op/s
// Warmup 2: 618 op, 1844 ms, 1843961526.2 ns, 4132327 ticks, 2983756.5149 ns/op, 335.1 op/s
// Warmup 3: 618 op, 1846.3 ms, 1846329660.1 ns, 4137634 ticks, 2987588.4468 ns/op, 334.7 op/s
// Warmup 4: 618 op, 1863.4 ms, 1863360412 ns, 4175800 ticks, 3015146.2977 ns/op, 331.7 op/s
// Warmup 5: 618 op, 1843.1 ms, 1843136449.9 ns, 4130478 ticks, 2982421.44 ns/op, 335.3 op/s
Target 1: 618 op, 1894.1 ms, 1894104207.7 ns, 4244697 ticks, 3064893.54 ns/op, 326.3 op/s
Target 2: 618 op, 1857 ms, 1857038248.5 ns, 4161632 ticks, 3004916.2597 ns/op, 332.8 op/s
Target 3: 618 op, 1858.6 ms, 1858642439.4 ns, 4165227 ticks, 3007512.0379 ns/op, 332.5 op/s
Target 4: 618 op, 1886 ms, 1886027474.3 ns, 4226597 ticks, 3051824.392 ns/op, 327.7 op/s
Target 5: 618 op, 1877.9 ms, 1877898978.4 ns, 4208381 ticks, 3038671.486 ns/op, 329.1 op/s
Target 6: 618 op, 1851.6 ms, 1851616127.6 ns, 4149481 ticks, 2996142.6013 ns/op, 333.8 op/s
Target 7: 618 op, 1879 ms, 1878980189.7 ns, 4210804 ticks, 3040421.0189 ns/op, 328.9 op/s
Target 8: 618 op, 1907.5 ms, 1907526310.7 ns, 4274776 ticks, 3086612.1533 ns/op, 324 op/s
Target 9: 618 op, 1873.3 ms, 1873337185.8 ns, 4198158 ticks, 3031289.9446 ns/op, 329.9 op/s
Target 10: 618 op, 1930 ms, 1930014881.7 ns, 4325173 ticks, 3123001.4267 ns/op, 320.2 op/s
// Benchmark finished

AverageTime (ns/op): Avr=3046129.23325238 +- 26471.2504589083
OperationsPerSecond: Avr=328.460504758306 +- 2.67094909262466

// ***** Competition: Finish  *****

```ini
BenchmarkDotNet=v0.7.8.0
OS=Microsoft Windows NT 6.2.9200.0
Processor=Intel(R) Core(TM) i5-2410M CPU @ 2.30GHz, ProcessorCount=4
HostCLR=MS.NET 4.0.30319.42000, Arch=64-bit