import React from 'react';
import OverviewCard from './components/OverviewCard.jsx';
import ModuleSection from './components/ModuleSection.jsx';
import StatusTable from './components/StatusTable.jsx';
import './styles.css';

const highlights = [
  {
    title: 'Investment Hub',
    description:
      'Track funded projects, smart contract status, and investor participation across the portfolio.'
  },
  {
    title: 'Farm Management',
    description: 'Plan tasks, manage expenses, and monitor field activities with real-time updates.'
  },
  {
    title: 'Marketplace',
    description: 'List fresh produce, review buyer requests, and manage product visibility.'
  }
];

const modules = [
  {
    title: 'Investment Workflow',
    items: [
      'Project submission and verification',
      'Funding milestones and profit-sharing contracts',
      'Investor dashboards and performance analytics'
    ]
  },
  {
    title: 'Management Workflow',
    items: [
      'Daily task scheduling',
      'Expense tracking and reporting',
      'Field documentation and progress notes'
    ]
  },
  {
    title: 'Marketplace Workflow',
    items: [
      'Product listing approvals',
      'Buyer search and filtering tools',
      'Reported product review and moderation'
    ]
  }
];

const statusRows = [
  {
    label: 'Active projects',
    value: '24',
    note: '8 awaiting funding'
  },
  {
    label: 'Open tasks',
    value: '132',
    note: 'Next review in 3 days'
  },
  {
    label: 'Marketplace listings',
    value: '89',
    note: '12 pending approval'
  }
];

export default function App() {
  return (
    <div className="app">
      <header className="hero">
        <div>
          <p className="eyebrow">Agri-Pro Platform</p>
          <h1>Unified operations for investment, management, and marketplace teams.</h1>
          <p className="subtitle">
            A single interface for farmers, investors, and buyers to manage projects, track funding, and move
            harvests directly to market.
          </p>
          <div className="cta-row">
            <button className="primary">Launch dashboard</button>
            <button className="ghost">View API status</button>
          </div>
        </div>
        <div className="panel">
          <h2>Today’s overview</h2>
          <div className="panel-grid">
            {highlights.map((item) => (
              <OverviewCard key={item.title} title={item.title} description={item.description} />
            ))}
          </div>
        </div>
      </header>

      <main>
        <section className="modules">
          <h2>Module readiness</h2>
          <div className="module-grid">
            {modules.map((module) => (
              <ModuleSection key={module.title} title={module.title} items={module.items} />
            ))}
          </div>
        </section>

        <section className="status">
          <div className="status-header">
            <h2>Operational status</h2>
            <p>Snapshot of the most important activity across the platform.</p>
          </div>
          <StatusTable rows={statusRows} />
        </section>
      </main>
    </div>
  );
}
