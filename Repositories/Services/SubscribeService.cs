using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using Entities.UtilityModels;

namespace Repositories.Services
{
    //Service to connect to stripe for management of subscription (subscribe, unsubscribe)
    public class SubscribeService
    {
        private const string key = "sk_test_51IeiiiHIhuPseqDMOWxqJ2dNrwePknbcuLozxEstT4HKtkxDEQUh4ue3vxrjdSEQCq48wybcHzPlhgtimfbO51Oy00PG4Gu9zB";
        public static Session CreateSession(string priceId)
        {
            StripeConfiguration.ApiKey = key;
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                LineItems = new List<SessionLineItemOptions>
                {
                    // products
                    new SessionLineItemOptions
                    {
                        Price=priceId ?? "price_1IeipfHIhuPseqDM21xFFUeJ",
                        Quantity = 1,
                    },
                },

                Mode = "subscription",
                SuccessUrl = "https://localhost:44381/AdminSubscription/Success?session_id={CHECKOUT_SESSION_ID}", //websit,stripe will redirect to this
                CancelUrl = "https://localhost:44381/AdminSubscription/Index",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }

        public static SubscriptionModel Success(string session_id, string company)
        {
            StripeConfiguration.ApiKey = key;
            var sessionService = new SessionService();
            Session session = sessionService.Get(session_id);

            // vasi customer id = session.CustomerId;
            var options = new CustomerUpdateOptions
            {
                Name = company
            };
            new CustomerService().Update(session.CustomerId, options);
            var subscription = new SubscriptionService().Get(session.SubscriptionId);
            return new SubscriptionModel { SubscriptionId = subscription.Id, SubsciptionStatus = subscription.Status };
        }

        public static string Unsubscribe(string subscriptionId)
        {
            StripeConfiguration.ApiKey = key;
            try
            {
                new SubscriptionService().Cancel(subscriptionId);

            }
            catch(Exception)
            {
                return "Already Unsubscribed";
            }

            var subscription = new SubscriptionService().Get(subscriptionId);
            return subscription.Status;
        }
    }
}
