const Easypost = require('@easypost/api');
const api = new Easypost('<YOUR_PRODUCTION_API_KEY>');

const referralUser = new api.Referral({
  name: 'Test Referral',
  email: 'test@example.com',
  phone: '1111111111',
});

referralUser.save().then(console.log);
