const Easypost = require('@easypost/api');

const api = new Easypost(process.env.EASYPOST_API_KEY);

const order = new api.Order({
  carrier_accounts: ['ca_...'],
  service: 'NextDayAir',
  to_address: 'adr_...',
  from_address: 'adr_...',
  shipments: [
    {
      parcel: {
        predefined_package: 'FedExBox',
        weight: 10.2,
      },
    },
    {
      parcel: {
        predefined_package: 'FedExBox',
        weight: 17.5,
      },
    },
  ],
});

order.save().then(console.log);
