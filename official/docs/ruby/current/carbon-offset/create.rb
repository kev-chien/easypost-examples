require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

EasyPost::Shipment.create(
  {
    to_address: {
      name: 'Dr. Steve Brule',
      street1: '179 N Harbor Dr',
      city: 'Redondo Beach',
      state: 'CA',
      zip: '90277',
      country: 'US',
      phone: '4155559999',
      email: 'dr_steve_brule@gmail.com',
    },
    from_address: {
      name: 'EasyPost',
      street1: '417 Montgomery Street',
      street2: '5th Floor',
      city: 'San Francisco',
      state: 'CA',
      zip: '94104',
      country: 'US',
      phone: '4153334445',
      email: 'support@easypost.com',
    },
    parcel: {
      length: 20.2,
      width: 10.9,
      height: 5,
      weight: 65.9,
    },
  },
  nil,
  true,
)

puts shipment
