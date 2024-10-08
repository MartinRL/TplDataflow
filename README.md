# Experiments in TPL Dataflow

```mermaid
flowchart TB
    
    %% Colors %%
    %% Rationale: Green is often associated with "action," "go," and "processing," which fits the nature of execution blocks that actively transform or process data.
    classDef green fill:#28a745,stroke:#000,stroke-width:2px,color:#fff;
    %% Rationale: Blue is often associated with "organization," "grouping," and "collective operations." It provides a calm, structural feel, appropriate for blocks that group or batch items.
    classDef blue fill:#2374f7,stroke:#000,stroke-width:2px,color:#fff;
    %% Rationale: Orange is often linked with "storage" or "holding" phases and is visually distinct. Buffer blocks temporarily store items before they are processed, so orange can indicate this intermediary state.
    classDef orange fill:#f28c28,stroke:#000,stroke-width:2px,color:#fff;
    classDef light-yellow fill:#fffacd,stroke:#000,stroke-width:2px,color:#000;

    subgraph "Buffering Blocks"
        %% direction TD
        BB("⧉ BufferBlock<T>"):::orange
        BrB("⊛ BroadcastBlock<T>"):::orange
        WOB("⨀ WriteOnceBlock<T>"):::orange
        bufferingNote("hold data for use by data consumers"):::light-yellow
    end
    
    subgraph "Grouping Blocks"
        %% direction TD
        BaB("⌗ BatchBlock<T>"):::blue
        JB("⊛ JoinBlock<T1, T2>"):::blue
        BJB("⟟ BatchedJoinBlock<T1, T2>"):::blue
        groupingNote("combine data from one or more sources \nand under various constraints"):::light-yellow
    end

    subgraph "Execution Blocks"
        %% direction TD
        AB("◊ ActionBlock<T>"):::green
        TB("‡ TransformBlock<T, U>"):::green
        TMB("⊕ TransformManyBlock<TInput, TOutput>"):::green
        executiongNote("call a user provided delegate for \neach piece of received data"):::light-yellow
    end
```

Read more at [Dataflow (Task Parallel Library) at Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/standard/parallel-programming/dataflow-task-parallel-library).
