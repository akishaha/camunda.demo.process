﻿using Camunda.Worker;

namespace camunda.helper.Camunda.Worker.Handlers.Saga.Orchestrator
{
    [HandlerTopics("Reverse_Inventory")]
    public class ReverseInventoryHandler : IExternalTaskHandler
    {
        private readonly ILogger<ReverseInventoryHandler> _logger;
        public ReverseInventoryHandler(ILogger<ReverseInventoryHandler> logger)
        {
            _logger = logger;
        }
        public async Task<IExecutionResult> HandleAsync(ExternalTask externalTask, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Reverse_Inventory handler is called from Camunda...");
            try
            {
                //_logger.LogInformation($"Adding Tea leaves for {externalTask.Variables["numberOfCups"].AsInteger()} number of cups..........");
                ////Mimicking operation
                //Task.Delay(5000).Wait();

                //return success
                return new CompleteResult();
            }
            catch (Exception ex)
            {
                _logger.LogError($"error occured!! error messge: {ex.Message}");
                //return failure
                return new BpmnErrorResult("Reverse_Inventory_Failed", "Error occured while invoking Reverse_Inventory..");
            }
        }
    }
}