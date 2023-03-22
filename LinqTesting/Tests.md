# Scenario 1

Suggested Path: `Any(condition)`

Bad Path: `Where(condition).Any()`

| Method        | Suggested Path | Bad Path | From bad to good |
|---------------|---------------:|---------:|-----------------:|
| Greater Than  |       4,207 ns | 1,519 ns |    176% increase |
| Less Than     |       12.59 ns | 22.28 ns |   43.5% decrease |
| Equals        |       3,987 ns | 1,531 ns |    160% increase |
| Not Equal     |       12.43 ns | 22.93 ns |   45.8% decrease |
| Greater Equal |       4,043 ns | 1,534 ns |  163.6% increase |
| Less Equal    |       12.51 ns | 22.86 ns |   45.3% decrease |

# Scenario 2

Suggested Path: `FirstOrDefault(condition)`

Bad Path: `Where(condition).FirstOrDefault()`

| Method        | Suggested Path | Bad Path | From bad to good |
|---------------|---------------:|---------:|-----------------:|
| Greater Than  |       4,349 ns | 1,526 ns |    184% increase |
| Less Than     |          13 ns |    24 ns |   45.8% decrease |
| Equals        |        4377 ns | 1,532 ns |  185.7% increase |
| Not Equal     |          13 ns |    24 ns |   45.8% decrease |
| Greater Equal |        4809 ns | 1,531 ns |  218.1% increase |
| Less Equal    |          13 ns |    24 ns |   45.8% decrease |


# Scenario 3

Manually iterated via for each loop

| Method        | Suggested Path |
|---------------|---------------:|
| Greater Than  |         222 ns |
| Less Than     |         0.3 ns |
| Equals        |         219 ns |
| Not Equal     |         0.3 ns |
| Greater Equal |         219 ns |
| Less Equal    |         0.3 ns |