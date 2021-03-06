﻿using ByteartRetail.Domain.Repositories;

namespace ByteartRetail.Domain.Events.Handlers
{
    /// <summary>
    /// 表示用于处理订单已发货的领域事件的事件处理器。
    /// </summary>
    public class OrderDispatchedDomainEventHandler : DomainEventHandler<OrderDispatchedEvent>
    {
        #region Private Fields
        private readonly ISalesOrderRepository salesOrderRepository;
        #endregion

        #region Ctor
        /// <summary>
        /// 初始化一个新的<c>OrderDispatchedDomainEventHandler</c>类型。
        /// </summary>
        /// <param name="salesOrderRepository">用于初始化当前类型的销售订单仓储实例。</param>
        public OrderDispatchedDomainEventHandler(ISalesOrderRepository salesOrderRepository)
        {
            this.salesOrderRepository = salesOrderRepository;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 处理给定的事件。
        /// </summary>
        /// <param name="evnt">需要处理的事件。</param>
        public override void Handle(OrderDispatchedEvent evnt)
        {
            // TODO: 在此处可以执行一些与仓储相关的操作，然后根据操作结果更新evnt.Source
            // 中的相关属性。
        }

        #endregion
    }
}
